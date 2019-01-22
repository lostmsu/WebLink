namespace Lost.WebLink
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
			this.address = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
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
			this.Controls.Add(this.address);
			this.Name = "WebView";
			this.ResumeLayout(false);
			this.PerformLayout();
        }

		#endregion

		private TextBox address;
	}
}
