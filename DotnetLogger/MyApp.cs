using DotnetLogger.Common;
using System.Windows.Forms;

namespace DotnetLogger
{
	public partial class MyApp : Form
	{
		public MyApp()
		{
			InitializeComponent();
			LoggerHelper.Info("log info");
			LoggerHelper.Error("log error");
		}
	}
}
