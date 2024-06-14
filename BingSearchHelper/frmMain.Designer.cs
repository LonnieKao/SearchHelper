namespace BingSearchHelper
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wvMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtRangStart = new System.Windows.Forms.TextBox();
            this.txtRangEnd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblSearchCount = new System.Windows.Forms.Label();
            this.txtSearchTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wvMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wvMain
            // 
            this.wvMain.AllowExternalDrop = true;
            this.wvMain.CreationProperties = null;
            this.wvMain.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvMain.Location = new System.Drawing.Point(3, 71);
            this.wvMain.Name = "wvMain";
            this.wvMain.Size = new System.Drawing.Size(971, 482);
            this.wvMain.TabIndex = 0;
            this.wvMain.ZoomFactor = 1D;
            this.wvMain.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.wvMain_NavigationCompleted);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(680, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtRangStart
            // 
            this.txtRangStart.Location = new System.Drawing.Point(102, 18);
            this.txtRangStart.Name = "txtRangStart";
            this.txtRangStart.Size = new System.Drawing.Size(100, 22);
            this.txtRangStart.TabIndex = 2;
            this.txtRangStart.Text = "15";
            // 
            // txtRangEnd
            // 
            this.txtRangEnd.Location = new System.Drawing.Point(225, 18);
            this.txtRangEnd.Name = "txtRangEnd";
            this.txtRangEnd.Size = new System.Drawing.Size(100, 22);
            this.txtRangEnd.TabIndex = 3;
            this.txtRangEnd.Text = "20";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.wvMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.23022F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.76978F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 556);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.lblSearchCount);
            this.panel1.Controls.Add(this.txtSearchTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRangStart);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtRangEnd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 62);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(860, 16);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(93, 23);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "test";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Visible = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblSearchCount
            // 
            this.lblSearchCount.AutoSize = true;
            this.lblSearchCount.Location = new System.Drawing.Point(530, 23);
            this.lblSearchCount.Name = "lblSearchCount";
            this.lblSearchCount.Size = new System.Drawing.Size(11, 12);
            this.lblSearchCount.TabIndex = 8;
            this.lblSearchCount.Text = "0";
            // 
            // txtSearchTime
            // 
            this.txtSearchTime.Location = new System.Drawing.Point(414, 18);
            this.txtSearchTime.Name = "txtSearchTime";
            this.txtSearchTime.Size = new System.Drawing.Size(100, 22);
            this.txtSearchTime.TabIndex = 7;
            this.txtSearchTime.Text = "35";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "查詢次數:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "延遲區間(秒):";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "BingSearchHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvMain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtRangStart;
        private System.Windows.Forms.TextBox txtRangEnd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchCount;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label4;
    }
}

