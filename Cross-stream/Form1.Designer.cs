namespace Cross_stream
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnSpotify = new Button();
            btnSC = new Button();
            btnYT = new Button();
            btnYTM = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-2, 34);
            webView21.Name = "webView21";
            webView21.Size = new Size(800, 417);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // btnSpotify
            // 
            btnSpotify.Location = new Point(10, 5);
            btnSpotify.Name = "btnSpotify";
            btnSpotify.Size = new Size(82, 23);
            btnSpotify.TabIndex = 1;
            btnSpotify.Text = "Spotify";
            btnSpotify.UseVisualStyleBackColor = true;
            btnSpotify.Click += btnSpotify_Click;
            // 
            // btnSC
            // 
            btnSC.Location = new Point(98, 5);
            btnSC.Name = "btnSC";
            btnSC.Size = new Size(80, 23);
            btnSC.TabIndex = 2;
            btnSC.Text = "Soundcloud";
            btnSC.UseVisualStyleBackColor = true;
            btnSC.Click += btnSC_Click;
            // 
            // btnYT
            // 
            btnYT.Location = new Point(184, 5);
            btnYT.Name = "btnYT";
            btnYT.Size = new Size(80, 23);
            btnYT.TabIndex = 3;
            btnYT.Text = "Youtube";
            btnYT.UseVisualStyleBackColor = true;
            btnYT.Click += btnYT_Click;
            // 
            // btnYTM
            // 
            btnYTM.Location = new Point(270, 5);
            btnYTM.Name = "btnYTM";
            btnYTM.Size = new Size(80, 23);
            btnYTM.TabIndex = 4;
            btnYTM.Text = "YT Music";
            btnYTM.UseVisualStyleBackColor = true;
            btnYTM.Click += btnYTM_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYTM);
            Controls.Add(btnYT);
            Controls.Add(btnSC);
            Controls.Add(btnSpotify);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cross-stream";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnSpotify;
        private Button btnSC;
        private Button btnYT;
        private Button btnYTM;
    }
}
