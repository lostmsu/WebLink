namespace LOST.WebLink
{
    using System.Windows.Forms;

    partial class WebView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.browser = new System.Windows.Forms.WebBrowser();
			this.address = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// browser
			// 
			this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browser.Location = new System.Drawing.Point(0, 20);
			this.browser.Name = "browser";
			this.browser.ScriptErrorsSuppressed = true;
			this.browser.Size = new System.Drawing.Size(150, 130);
			this.browser.TabIndex = 0;
			// 
			// address
			// 
			this.address.Dock = System.Windows.Forms.DockStyle.Top;
			this.address.Location = new System.Drawing.Point(0, 0);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(150, 20);
			this.address.TabIndex = 1;
			// 
			// WebView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.browser);
			this.Controls.Add(this.address);
			this.Name = "WebView";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private WebBrowser browser;
		private TextBox address;
	}
}
