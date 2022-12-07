using CommandLine;
using DigitalTwin.Physical;
using DigitalTwin.Comms;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using DigitalTwin;
using System.Threading.Tasks;

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

    // Program logger
    private static ILogger<Program> logger = null;

    static async Task Main(string[] args)
    {
      // Parse command line arguments
      int parseResult = ParseCommandLineArguments(args);
      if (parseResult != ParseOK)
      {
        Environment.Exit(parseResult);
      }

      // Create logger factory
      var loggerFactory = CreateLoggerFactory();
      logger = loggerFactory.CreateLogger<Program>();

      // Set up physical twin
      IPhysicalTwin physicalTwin = CreateSenseHatTwin(loggerFactory);

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
          logger.LogError(ex, "Failed to load certificate");
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

      // Build digital twin
      PiDigitalTwin digitalTwin = null;
      try
      {
        digitalTwin = new PiDigitalTwinFactory()
          .SetLoggerFactory(loggerFactory)
          .SetPhysicalTwin(physicalTwin)
          .ConfigureUaServer(options =>
          {
            options.LoggerFactory = loggerFactory;
            options.AutoAccept = autoAccept;
          })
          .BuildDigitalTwin();
      } catch (Exception ex)
      {
        logger.LogCritical(ex, "Failed to build digital twin");
        throw;
      }

      // Warn if auto-accept is enabled
      if (digitalTwin.UaServer.AutoAccept)
      {
        logger.LogWarning("Certificate auto-accept is ON");
      }

      // Configure stop event
      ManualResetEvent quitEvent = new ManualResetEvent(false);
      Console.CancelKeyPress += (sender, eArgs) =>
      {
        quitEvent.Set();
        eArgs.Cancel = true;
      };

      try
      {
        // Launch server
        await digitalTwin.LaunchUaServer(
          "Resources/Configuration/PiDigitalTwin.Config.xml",
          certificate,
          certificatePassword);

        logger.LogInformation("Running server, CTRL+C to stop...");

        // Run until stop event
        quitEvent.WaitOne(Timeout.Infinite);
      }
      catch (Exception ex)
      {
        logger.LogError(ex, "Failed");
      }
      finally
      {
        logger.LogWarning("Stopping server...");
        digitalTwin.StopUaServer();
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

    private static IPhysicalTwin CreateSenseHatTwin(ILoggerFactory loggerFactory)
    {
      try
      {
        return new SenseHatDevice(loggerFactory);
      }
      catch (Exception)
      {
        logger.LogWarning("Failed to create SenseHat device, using simulated SenseHat");
        return new SenseHatTest(loggerFactory);
      }
    }
  }
}
