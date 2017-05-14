using System.IO;
using log4net;

namespace ManagePhones.Util.Logger
{
    public class AppLogger
    {
        private static ILog _logger;

        private static ILog Log
        {
            get
            {
                if (_logger == null)
                {
                    _logger = LogManager.GetLogger("root");
                }
                return _logger;
            }
        }

        #region Public Methods
        public void LogError(string message)
        {
            Log.Error(message);
        }

        public void LogFatal(string message)
        {
            Log.Fatal(message);
        }
        #endregion
    }
}
