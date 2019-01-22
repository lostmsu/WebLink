using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Edge = Microsoft.Toolkit.Forms.UI.Controls.WebView;

namespace Lost.WebLink
{
	public partial class WebView : UserControl
	{
        readonly WebBrowser browser;
        readonly Edge edge;
		public WebView()
		{
			InitializeComponent();

            Debug.Assert(Thread.CurrentThread.GetApartmentState() == ApartmentState.STA);
            Debug.WriteLine("WebView created by thread {0}", Thread.CurrentThread.ManagedThreadId);

            Control browserControl;
            if (Edge.IsSupported) {
                browserControl = this.edge = new Edge();
            } else {
                browserControl = this.browser = new WebBrowser();
                this.browser.ScriptErrorsSuppressed = true;
            }
            ConfigureBrowserLayout(browserControl);
            this.Controls.Add(browserControl);
            this.PerformLayout();
        }

        static void ConfigureBrowserLayout(Control browserControl) {
            browserControl.Dock = DockStyle.Fill;
            browserControl.Location = new Point(0, 20);
            browserControl.Name = "browser";
            browserControl.Size = new Size(150, 130);
            browserControl.TabIndex = 0;
        }

		public TextBox Address
		{
			get { return address; }
		}

        public event WebBrowserNavigatingEventHandler Navigating {
            add {
                if (this.browser != null)
                    this.browser.Navigating += value;
            }
            remove {
                if (this.browser != null)
                    this.browser.Navigating -= value;
            }
        }
        public event WebBrowserNavigatedEventHandler Navigated {
            add {
                if (this.browser != null)
                    this.browser.Navigated += value;
            }
            remove {
                if (this.browser != null)
                this.browser.Navigated -= value;
            }
        }
        public Uri Url => this.browser?.Url ?? this.edge.Source;
        public bool AllowNavigation {
            get => this.browser?.AllowNavigation ?? true;
            set {
                if (this.browser != null)
                    this.browser.AllowNavigation = value;
                else
                    Debug.WriteLine("Can't disable navigation on modern WebView: not implemented");
            }
        }

        public void Navigate(string url) {
            if (this.browser != null)
                this.browser.Navigate(url);
            else
                if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
                    this.edge.Navigate(uri);
        }
    }
}
