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
                lastIdx = keyIdx.Last();
                Key += " " + keyWards[lastIdx];
                keyIdx.Remove(lastIdx);

                Task.Delay(delay).Wait();
                wvMain.Invoke((Action)(() =>
                {
                    wvMain.ExecuteScriptAsync($@"document.getElementById('sb_form_q').value = '{Key}';");
                    wvMain.ExecuteScriptAsync(@"document.getElementById('sb_form_go').click();");
                }));

                int.TryParse(lblSearchCount.Text, out int count);
                lblSearchCount.Invoke((Action)(() => { lblSearchCount.Text = (count + 1).ToString(); }));
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

            for (int i = 0; i < SearchNum*2; i++)
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
            lastIdx = keyIdx.Last();
            keyWord += " " + keyWards[lastIdx];
            keyIdx.Remove(lastIdx);
            Init(keyWord);
            lblSearchCount.Text = "1";
        }

        private void wvMain_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            NextSerach();
        }

        private void NextSerach()
        {
            Task.Factory.StartNew(() =>
            {
                Task.Delay(1000).Wait();
                ExeSerach();
            });
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
            wvMain.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Linux; Android 9; ASUS_X00TDB Build/PKQ1; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/120.0.6099.144 Mobile Safari/537.36";

            wvMain.Source = new Uri($@"https://www.bing.com/search?q=test");

        }
    }
}
