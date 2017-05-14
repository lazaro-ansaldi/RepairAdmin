using ManagePhones.Util.Enums;
using ManagePhones.Util.Logger;
using System;

namespace ManagePhones.Util.Exceptions
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
        

        public LoggedException(string message, ExType level, Exception ex) : base(message, ex)
        {
            _log = new AppLogger();
            _ex = ex;
            switch (level)
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
    }
}
