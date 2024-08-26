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
    using System.Configuration;
    using BingSearchHelper.Models;

    public partial class frmMain : Form
    {

        private string[] keyWards;
        private List<int> keyIdx = new List<int>();

        MD_Args args = new MD_Args();
        //int RangS = 3;
        //int RangE = 5;
        //int SearchNum = 35;

        Random rand = new Random();

        EMode currentMode = EMode.pc;

        string MobileAgent = ConfigurationManager.AppSettings["UserAgnet"];

        int delay;

        private bool InitFlag = true;
        private bool resetFlag = false;


        private string CurrentPCUserAgent = string.Empty;

        enum EMode
        {
            mobile = 0,
            pc = 1,
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtRangStart.Text = args.RngS.ToString();
            txtRangEnd.Text = args.RngE.ToString();
            txtSearchTime.Text= args.SearchNum.ToString();  
            wvMain.Source = new Uri($@"https://www.google.com.tw");
            keyWards = File.ReadAllLines("keywords.txt");
        }

        private void GetInitModePCMode()
        {
            if (Properties.Settings.Default.SearchMode == "PC")
            {
                currentMode = EMode.pc;
                lblMode.Text = "目前模式:PC";
            }
            else
            {
                wvMain.CoreWebView2.Settings.UserAgent = MobileAgent;
                currentMode = EMode.mobile;
                lblMode.Text = "目前模式:mobile";
            }
        }


        private void changeMode()
        {
            if (currentMode == EMode.mobile)
            {
                wvMain.CoreWebView2.Settings.UserAgent = CurrentPCUserAgent;
                currentMode = EMode.pc;
                lblMode.Text = "目前模式:PC";
                Properties.Settings.Default.SearchMode = "PC";
                Properties.Settings.Default.Save();
            }
            else
            {
                wvMain.CoreWebView2.Settings.UserAgent = MobileAgent;
                currentMode = EMode.mobile;
                lblMode.Text = "目前模式:mobile";
                Properties.Settings.Default.SearchMode = "Mobile";
                Properties.Settings.Default.Save();
            }
            //重置
            resetFlag = false;
            wvMain.Source = new Uri($@"https://www.bing.com/");
        }

        private void Init(string KeyWord)
        {
            wvMain.Source = new Uri($@"https://www.bing.com/search?q={KeyWord}");

            Task.Delay(2000).Wait();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRangStart.Text, out args.RngS) || !int.TryParse(txtRangEnd.Text, out args.RngE) || !int.TryParse(txtSearchTime.Text, out args.SearchNum))
            {
                MessageBox.Show("參數設定錯誤");
                return;
            }
            args.SaveArgs();

            rand = new Random();

            for (int i = 0; i < args.SearchNum * 2; i++)
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

            NextSerach();
        }

        private void wvMain_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (InitFlag)
            {
                CurrentPCUserAgent = wvMain.CoreWebView2.Settings.UserAgent;
                GetInitModePCMode();
                wvMain.Source = new Uri($@"https://www.bing.com/");
                InitFlag = false;
            }
            else if (resetFlag)
            {
                changeMode();
            }
            //else
            //{
            //    NextSerach();
            //}
            label5.Invoke((Action)(() => { label5.Text = "UserAgent:" + wvMain.CoreWebView2.Settings.UserAgent; }));
        }

        private void CountDown()
        {
            var val = delay;
            while (val >= 0)
            {
                Task.Delay(1000).Wait();
                val -= 1000;
                lblCountDown.Invoke((Action)(() =>
                {
                    if (val >= 0)
                    {
                        lblCountDown.Text = string.Format("CountDown:{0}", (val / 1000) + "." + (val % 1000));
                    }
                    else
                    {
                        lblCountDown.Text = string.Format("CountDown:{0}", 0);
                    }
                }));
            }
        }

        private void NextSerach()
        {
            Task.Factory.StartNew(() =>
            {
                //delay = rand.Next(RangS * 10, RangE * 10) * 100;
                //label4.Invoke((Action)(() => { label4.Text = "Delay:" + (delay / 1000).ToString() + "." + (delay % 1000).ToString(); }));
                ////第一次暫停
                //Task.Factory.StartNew(() =>
                //{
                //    CountDown();
                //});
                //Task.Delay(delay).Wait();
                while (keyIdx.Count > 0)
                {
                    delay = rand.Next(args.RngS * 10, args.RngE * 10) * 100;

                    var lastIdx = keyIdx.Last();
                    var Key = keyWards[lastIdx];
                    keyIdx.Remove(lastIdx);
                    lastIdx = keyIdx.Last();
                    Key += " " + keyWards[lastIdx];
                    keyIdx.Remove(lastIdx);

                    int.TryParse(lblSearchCount.Text, out int count2);
                    label4.Invoke((Action)(() => { label4.Text = "Delay:" + (delay / 1000).ToString() + "." + (delay % 1000).ToString(); }));
                    Task.Factory.StartNew(() =>
                    {
                        CountDown();
                    });
                    Task.Delay(delay).Wait();

                    wvMain.Invoke((Action)(() =>
                    {
                        wvMain.ExecuteScriptAsync($@"document.getElementById('sb_form_q').value = '{Key}';");
                        wvMain.ExecuteScriptAsync(@"document.getElementById('sb_form_go').click();");
                    }));

                    int.TryParse(lblSearchCount.Text, out int count);
                    lblSearchCount.Invoke((Action)(() => { lblSearchCount.Text = (count + 1).ToString(); }));
                }
            });
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("帳號將被登出!!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            //清除快取
            ClearCache();
            resetFlag = true;
            //先轉到google去
            wvMain.Source = new Uri($@"https://www.google.com.tw");
        }

        private async void ClearCache()
        {
            //wvMain.CoreWebView2.Profile.ClearBrowsingDataAsync();
            //var dataKinds = CoreWebView2BrowsingDataKinds.AllProfile & ~CoreWebView2BrowsingDataKinds.Cookies;
            //var dataKinds = CoreWebView2BrowsingDataKinds.FileSystems;
            var dataKinds = CoreWebView2BrowsingDataKinds.AllProfile;
            await wvMain.CoreWebView2.Profile.ClearBrowsingDataAsync(dataKinds);
            keyIdx.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearCache();

            wvMain.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Linux; Android 9; ASUS_X00TDB Build/PKQ1; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/120.0.6099.144 Mobile Safari/537.36";
            wvMain.Source = new Uri($@"https://www.bing.com/search?q=test");
        }
    }
}
