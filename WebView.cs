using System.Windows.Forms;

namespace Lost.WebLink
{
	public partial class WebView : UserControl
	{
		public WebView()
		{
			InitializeComponent();
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
