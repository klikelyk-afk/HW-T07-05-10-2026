using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WinFormsApp_Babylon_2026_v2;

public enum LogLevel
{
    Debug,
    Info,
    Warning,
    Error
}

// 1. Sealed
// 2. Do not allove to be created via "new" from outside.
// 3. Be 1000% sure only ONE object is created. -> static -> 1) Only one instance. 2) "Lazy" loading.
// 4. Get the single reference (via property OR method (when thread safe)).

internal sealed class Logger
{
    private readonly string logPath = string.Empty;
    private int recordsNumber = 0;
    private object lockObject = new object();

    public static Logger Instance { get; } = new();


    private Logger()
    {
        logPath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
        File.AppendAllLines(logPath, new string[] { string.Empty });
    }

    static Logger()
    {
    }

    // Formats:
    // [DateTime] : [Thread ID] : [Process Id] : [Log levels] | [Functionality] : [Method] - "Some error"
    // 23.06.2025 19:14:53 : [UI] : [Debug]     | Music playback : StartPlayback(...) - Playback was started with no errors. 
    // 23.06.2025 19:14:58 : [UI] : [Warning]   | Music playback : GetNetxBufferPart(...) - Cannot load all the bytes data in time. Method completed with timout. 
    // 1. Playback was started with no errors. 
    // 2. Playback was started with no errors.

    public void LogData(LogLevel logLevel, string message)
    {
        string functionality = "functionality";
        string method = "method";
        string data = $"{DateTime.Now.ToString()} : [{logLevel}] | {functionality} : {method} - {message}";
        Debug.WriteLine(data);
        
        lock (lockObject)
        {
            File.AppendAllLines(logPath, new string[] { message });
        }

        recordsNumber++;
    }
}
