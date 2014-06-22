using System.Windows.Forms;

namespace Lost.WebLink
{
	using System.Diagnostics;
	using System.Threading;

	public partial class WebView : UserControl
	{
		public WebView()
		{
			InitializeComponent();

			Debug.Assert(Thread.CurrentThread.GetApartmentState() == ApartmentState.STA);
			Debug.WriteLine("WebView created by thread {0}", Thread.CurrentThread.ManagedThreadId);
		}

		public WebBrowser Browser
		{
			get { return browser; }
		}

		public TextBox Address
		{
			get { return address; }
		}
	}
}
