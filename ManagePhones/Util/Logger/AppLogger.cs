using System;
using System.IO;

namespace Util.Logger
{
    public class AppLogger
    {
        public AppLogger()
        {
            _path = @"C:\Users\Lazaro\Documents\GestionReparaciones\Source\ManagePhones\UiDesktop\Error.log";
        }

        private readonly string _path;
        private StreamWriter _writer;

        public void LogError(string message)
        {
            using (_writer = new StreamWriter(_path))
            {
                _writer.WriteLine(DateTime.Now.ToString("dd/MM/yyyy mm:hh:ss") + " -- " + message);
            }
        }

        public void LogFatal(string message)
        {
            LogError(message);
        }
    }
}
