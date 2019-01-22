using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lost.WebLink
{
	public partial class WebView : UserControl
	{
        readonly WebBrowser browser;
		public WebView()
		{
			InitializeComponent();

            Debug.Assert(Thread.CurrentThread.GetApartmentState() == ApartmentState.STA);
            Debug.WriteLine("WebView created by thread {0}", Thread.CurrentThread.ManagedThreadId);

            this.browser = new WebBrowser();

            // 
            // browser
            // 
            this.browser.Dock = DockStyle.Fill;
            this.browser.Location = new Point(0, 20);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new Size(150, 130);
            this.browser.TabIndex = 0;
            this.Controls.Add(this.browser);
        }

		public TextBox Address
		{
			get { return address; }
		}

        public event WebBrowserNavigatingEventHandler Navigating {
            add { this.browser.Navigating += value; }
            remove { this.browser.Navigating -= value; }
        }
        public event WebBrowserNavigatedEventHandler Navigated {
            add { this.browser.Navigated += value;  }
            remove { this.browser.Navigated -= value; }
        }
        public Uri Url => this.browser.Url;
        public bool AllowNavigation {
            get => this.browser.AllowNavigation;
            set => this.browser.AllowNavigation = value;
        }

        public void Navigate(string url) => this.browser.Navigate(url);
    }
}
