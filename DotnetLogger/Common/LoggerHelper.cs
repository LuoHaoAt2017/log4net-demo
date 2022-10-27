using log4net;

namespace DotnetLogger.Common
{
	internal class LoggerHelper
	{
		private static readonly ILog logError = LogManager.GetLogger("LogError");
		private static readonly ILog logInfo = LogManager.GetLogger("LogInfo");

		public static void Info(string mesg)
		{
			if (logInfo.IsInfoEnabled)
			{
				logInfo.Info(mesg);
			}
		}

		public static void Error(string mesg)
		{
			if (logError.IsErrorEnabled)
			{
				logError.Error(mesg);
			}
		}
	}
}
