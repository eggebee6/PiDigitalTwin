using CommandLine;
using DigitalTwins.Comms;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ServerApp
{
  internal class Program
  {
    // Command line parse results
    private const int ParseOK = 0;
    private const int ParseFailed = 1;

    // Variables for command line options
    private static bool autoAccept = false;
    private static string certificateFilename = null;
    private static string certificatePassword = null;
    private static string logFilename = null;

    static void Main(string[] args)
    {
      // Parse command line arguments
      int parseResult = ParseCommandLineArguments(args);
      if (parseResult != ParseOK)
      {
        Environment.Exit(parseResult);
      }

      // Create logger factory
      var loggerFactory = CreateLoggerFactory();
      var logger = loggerFactory.CreateLogger<Program>();

      // Create server
      var server = new UaServer(options =>
      {
        options.AutoAccept = autoAccept;
        options.LoggerFactory = loggerFactory;
      });

      // Load certificate from file, or use default certificate if no filename is provided
      X509Certificate2 certificate = null;
      if (certificateFilename != null)
      {
        try
        {
          certificate = new X509Certificate2(certificateFilename, certificatePassword);
        }
        catch (Exception ex)
        {
          certificate = null;
          logger.LogError($"Failed to load certificate: {ex.Message}");
        }
      }

      if (certificate != null)
      {
        logger.LogInformation($"Using certificate: {certificate.SubjectName.Name}");
      }
      else
      {
        logger.LogInformation($"Using default certificate");
      }

      // Launch the sever, run until stopped
      try
      {
        if (server.AutoAccept)
        {
          logger.LogWarning("Certificate auto-accept is ON");
        }

        UaServer.LaunchServer(
            server,
            "Resources/Configuration/PiDigitalTwin.Config.xml",
            certificate,
            certificatePassword)
          .Wait();

        ManualResetEvent quitEvent = new ManualResetEvent(false);
        Console.CancelKeyPress += (sender, eArgs) =>
        {
          quitEvent.Set();
          eArgs.Cancel = true;
        };

        logger.LogInformation("Running server, CTRL+C to stop...");
        quitEvent.WaitOne(Timeout.Infinite);
        logger.LogWarning("Stopping server...");
      }
      catch (Exception ex)
      {
        logger.LogError($"Launch failed: {ex.Message}");
      }
      finally
      {
        UaServer.StopServer(server);
      }
    }

    private static int ParseCommandLineArguments(string[] args)
    {
      // Parse command line options
      int result = Parser.Default
        .ParseArguments<CommandLineOptions>(args)
        .MapResult(
          options =>
          {
            autoAccept = options.AutoAccept;
            certificateFilename = options.CertificateFilename;
            certificatePassword = options.CertificatePassword ?? string.Empty;
            logFilename = options.LogFile;

            return ParseOK;
          },
          errors =>
          {
            return ParseFailed;
          });

      return result;
    }

    private static LoggerFactory CreateLoggerFactory()
    {
      var loggerConfig = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.Console();

      if (logFilename != null)
      {
        loggerConfig.WriteTo.File(logFilename);
      }

      LoggerFactory loggerFactory = new LoggerFactory();
      loggerFactory.AddSerilog(loggerConfig.CreateLogger());

      return loggerFactory;
    }
  }
}
