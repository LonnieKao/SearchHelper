namespace BingSearchHelper
{
    using Microsoft.Web.WebView2.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
    

    public partial class frmMain : Form
    {

        private string[] keyWards;
        private List<int> keyIdx = new List<int>();

        int RangS = 3;
        int RangE = 5;
        int SearchNum = 35;

        Random rand = new Random();

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wvMain.Source = new Uri($@"https://www.bing.com/");
            
            keyWards = File.ReadAllLines("keywords.txt");
        }

        private void Init(string KeyWord)
        {
            wvMain.Source = new Uri($@"https://www.bing.com/search?q='{KeyWord}'");

            Task.Delay(2000).Wait();
        }

        private void ExeSerach(string txtArarName = "sb_form_q", string goActionName = "sb_form_go")
        {
            if (keyIdx.Count > 0)
            {
                var delay = rand.Next(RangS * 10, RangE * 10) * 100;

                var lastIdx = keyIdx.Last();
                var Key = keyWards[lastIdx];
                keyIdx.Remove(lastIdx);

                wvMain.ExecuteScriptAsync($@"document.getElementById('sb_form_q').value = '{Key}';");
                Task.Delay(delay).Wait();
                wvMain.ExecuteScriptAsync(@"document.getElementById('sb_form_go').click();");

                int.TryParse(lblSearchCount.Text, out int count);
                lblSearchCount.Text = (count + 1).ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRangStart.Text, out RangS) || !int.TryParse(txtRangEnd.Text, out RangE) || !int.TryParse(txtSearchTime.Text, out SearchNum))
            {
                MessageBox.Show("參數設定錯誤");
                return;
            }
            
            rand = new Random();

            for (int i = 0; i < SearchNum; i++)
            {
                int idx;
                do
                {
                    idx = rand.Next(0, keyWards.Length - 1);
                } while (keyIdx.Contains(idx));

                keyIdx.Add(idx);
            }
            var lastIdx = keyIdx.Last();
            var keyWord = keyWards[lastIdx];
            keyIdx.Remove(lastIdx);
            Init(keyWord);
            lblSearchCount.Text = "1";
        }

        private void wvMain_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Task.Delay(1000).Wait();
            ExeSerach();
        }


        private void SetMobileMode()
        {
            wvMain.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 15_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15E148";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wvMain.ExecuteScriptAsync(@"document.getElementById('sb_form_go').click();");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            wvMain.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Windows Phone 10.0; Android 6.0.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Mobile Safari/537.36 Edge/18.22621";

            wvMain.Source = new Uri($@"https://www.bing.com/search?q=test");

        }
    }
}
