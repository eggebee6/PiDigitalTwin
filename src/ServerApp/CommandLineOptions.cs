using CommandLine.Text;
using CommandLine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerApp
{
  internal class CommandLineOptions
  {
    [Option(shortName: 'a', longName: "autoAccept", Required = false, HelpText = "Auto-accept any certificate")]
    public bool AutoAccept { get; set; }

    [Option(shortName: 'c', longName: "certificate", Required = false, HelpText = "Server certificate filename")]
    public string CertificateFilename { get; set; }

    [Option(shortName: 'p', longName: "password", Required = false, HelpText = "Server certificate password")]
    public string CertificatePassword { get; set; }

    [Option(shortName: 'l', longName: "logFile", Required = false, HelpText = "Name of file for log output")]
    public string LogFile { get; set; }
  }
  // Example:  ServerApp --autoAccept --certificate ./Certificates/Server.pfx --password SuperSecret123
}
