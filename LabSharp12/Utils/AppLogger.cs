using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSharp12.Utils
{
    public class AppLogger
    {
        private readonly TextBox _logTb;
        public AppLogger(TextBox logTb)
        {
            _logTb = logTb;
        }


        public void WriteLine(string message)
        {
            _logTb.Text += message + Environment.NewLine;
        }

        public void Clear()
        {
            _logTb.Clear();
        }
    }

    public static class Log
    {
        private static AppLogger? Logger; 
        public static void Init(AppLogger logger)
        {
            Logger = logger;
        }

        public static void WriteLine(string message)
        {
            ThrowIfNotInitialized();
            Logger.WriteLine(message);
        }

        public static void Clear()
        {
            ThrowIfNotInitialized();
            Logger.Clear();
        }

        [MemberNotNull(nameof(Logger))]
        private static void ThrowIfNotInitialized()
        {
            if (Logger is null)
            {
                throw new Exception("Логгер не был инициализирован");
            }

        }
    }
}
