﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec04LibN
{
    public partial class Logger : ILogger
    {
        private static Logger _logger;
        private string _logFileName;
        private int _logID;
        private List<string> _logNamespaces;

        private Logger()
        {
            _logFileName = $"../../../LOG_{DateTime.Now.ToString("yyyyMMdd-hhmmss")}.txt";
            _logID = 0;
            _logNamespaces = new List<string>();
        }

        public static ILogger Create()
        {
            if (_logger is not null)
            {
                return _logger;
            }

            _logger = new Logger();

            return _logger;
        }

        public void Start(string title)
        {
            _logID++;

            _logNamespaces.Add(title);

            WriteToLogFile("STRT", $"Added namespace {title}");
        }

        public void Stop()
        {
            _logID++;

            string removedNamespace = string.Empty;

            if (_logNamespaces.Count > 0)
            {
                removedNamespace = _logNamespaces.Last();

                _logNamespaces.RemoveAt(_logNamespaces.Count - 1);

                WriteToLogFile("STOP", $"Removed namespace {removedNamespace}");

                return;
            }

            WriteToLogFile("STOP", $"No namespaces to remove");
        }

        public void Log(string message)
        {
            _logID++;

            WriteToLogFile("INFO", message);
        }

        private void WriteToLogFile(string logTypeName, string message)
        {
            string logID = _logID.ToString("D6");
            string logNamespace = string.Empty;
            foreach (var namespc in _logNamespaces)
            {
                logNamespace += $"{namespc}:";
            }    

            string log = $"{logID} - {DateTime.Now} - {logTypeName} {logNamespace}   {message}";

            if (File.Exists(_logFileName))
            {
                using (StreamWriter sw = File.AppendText(_logFileName))
                {
                    sw.WriteLine(log);
                }

                return;
            }

            using (StreamWriter sw = File.CreateText(_logFileName))
            {
                sw.WriteLine($"{logID} - {DateTime.Now} - INIT");
            }

            _logID++;

            WriteToLogFile(logTypeName, message);
        }
    }
}
