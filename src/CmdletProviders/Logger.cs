using System;
using System.Diagnostics;
using System.Management.Automation;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public class Logger {
    private static DynamicsCrmCmdletProvider _provider;
    private static DateTime? _previousDebugMessageTime;

    public static void RegisterProvider(DynamicsCrmCmdletProvider provider) {
      _provider = provider;
      }

    public static void WriteDebug(string message) {
      Write(provider => provider?.WriteDebug(AddTimestamp(message)));
    }

    private static string AddTimestamp(string message) {
      DateTime currentMessageTime = DateTime.Now;
      TimeSpan elapsed = _previousDebugMessageTime.HasValue ? currentMessageTime.Subtract(_previousDebugMessageTime.Value) : TimeSpan.Zero;
      _previousDebugMessageTime = currentMessageTime;

      return $"{DateTime.Now:HH:mm:ss.fff} +{elapsed.TotalSeconds:0.000}: {message}";
    }

    public static void WriteWarning(string message) {
      Write(provider => provider?.WriteWarning(message));
    }

    private static void Write(Action<DynamicsCrmCmdletProvider> writeAction) {
      //TODO: Provider can be null, and may throw when writing.
      try {
        writeAction(_provider);
      }
      catch (Exception e) {
        Debug.WriteLine(e.Message);
      }
    }

    public static void WriteError(Exception exception, ErrorCategory errorCategory, object targetObject) {
      Write(provider => provider?.WriteError(new ErrorRecord(exception, exception.HResult.ToString(), errorCategory, targetObject)));
    }

    public static void WriteVerbose(string message) {
      Write(provider => provider?.WriteVerbose(message));
    }
  }
}