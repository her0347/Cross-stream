using Microsoft.Web.WebView2.Core;

namespace Cross_stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWebViewAsync();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await InitializeWebViewAsync();
        }

        private async Task InitializeWebViewAsync()
        {
            // 1. Create WebView2 environment (important for extensions)
            var env = await CoreWebView2Environment.CreateAsync(
                null,
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WebView2Data"),
                new CoreWebView2EnvironmentOptions("--enable-extensions")
            );

            // 2. Initialize WebView2
            await webView21.EnsureCoreWebView2Async(env);

            // 3. Navigate to github page
            webView21.CoreWebView2.Navigate("https://sites.google.com/view/crosstream");
        }


        private void btnSpotify_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 == null)
            {
                MessageBox.Show("Browser not initialized yet.");
                return;
            }
            webView21.CoreWebView2.Navigate("https://www.spotify.com");
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.soundcloud.com");
        }

        private void btnYT_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.youtube.com");
        }

        private void btnYTM_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://music.youtube.com/");
        }
    }
}
