using System;
using Util.Logger;

namespace Util.Exceptions
{
    public class LoggedException : Exception
    {
        private Exception _ex;
        private AppLogger _log;

        public Exception Ex
        {
            get { return _ex; }
        }
        #region Constructors
        public LoggedException(string message) : base(message)
        {

        }

        public LoggedException()
        {

        }
        

        public LoggedException(string message, string level, Exception ex) : base(message, ex)
        {
            _log = new AppLogger();
            _ex = ex;
            ExType type = (ExType)Enum.Parse(typeof(ExType), level);
            switch (type)
            {
                case ExType.Error:
                    _log.LogError("MESSAGE: " + ex.Message + "\n *-*-*-*-*- \nSTACK TRACE: " + ex.StackTrace);
                    break;
                case ExType.Fatal:
                    _log.LogFatal("MESSAGE: " + ex.Message + "\n *-*-*-*-*- \nSTACK TRACE: " + ex.StackTrace);
                    break;
            }
        }
        #endregion
        public enum ExType
        {
            Error,
            Fatal
        }
    }
}
