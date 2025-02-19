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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAutoMode = new System.Windows.Forms.CheckBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSearchCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wvMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wvMain
            // 
            this.wvMain.AllowExternalDrop = true;
            this.wvMain.CreationProperties = null;
            this.wvMain.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvMain.Location = new System.Drawing.Point(3, 139);
            this.wvMain.Name = "wvMain";
            this.wvMain.Size = new System.Drawing.Size(971, 414);
            this.wvMain.TabIndex = 0;
            this.wvMain.ZoomFactor = 1D;
            this.wvMain.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.wvMain_NavigationCompleted);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(179, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(57, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtRangStart
            // 
            this.txtRangStart.Location = new System.Drawing.Point(8, 15);
            this.txtRangStart.Name = "txtRangStart";
            this.txtRangStart.Size = new System.Drawing.Size(100, 22);
            this.txtRangStart.TabIndex = 2;
            this.txtRangStart.Text = "15";
            // 
            // txtRangEnd
            // 
            this.txtRangEnd.Location = new System.Drawing.Point(131, 15);
            this.txtRangEnd.Name = "txtRangEnd";
            this.txtRangEnd.Size = new System.Drawing.Size(100, 22);
            this.txtRangEnd.TabIndex = 3;
            this.txtRangEnd.Text = "20";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.wvMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 556);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 130);
            this.panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAutoMode);
            this.groupBox4.Controls.Add(this.lblMode);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnChangeMode);
            this.groupBox4.Location = new System.Drawing.Point(9, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 64);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "模式設定:";
            // 
            // chkAutoMode
            // 
            this.chkAutoMode.AutoSize = true;
            this.chkAutoMode.Location = new System.Drawing.Point(672, 14);
            this.chkAutoMode.Name = "chkAutoMode";
            this.chkAutoMode.Size = new System.Drawing.Size(74, 16);
            this.chkAutoMode.TabIndex = 15;
            this.chkAutoMode.Text = "AutoMode";
            this.chkAutoMode.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(12, 18);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(53, 12);
            this.lblMode.TabIndex = 12;
            this.lblMode.Text = "目前模式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "UserAgent:";
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Location = new System.Drawing.Point(98, 13);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(123, 23);
            this.btnChangeMode.TabIndex = 9;
            this.btnChangeMode.Text = "切換模式並清除快取";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblCountDown);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblSearchCount);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(405, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 46);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "執行進度:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Delay:";
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Location = new System.Drawing.Point(242, 18);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(64, 17);
            this.lblCountDown.TabIndex = 15;
            this.lblCountDown.Text = "CountDown:";
            this.lblCountDown.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "目前次數:";
            // 
            // lblSearchCount
            // 
            this.lblSearchCount.AutoSize = true;
            this.lblSearchCount.Location = new System.Drawing.Point(153, 18);
            this.lblSearchCount.Name = "lblSearchCount";
            this.lblSearchCount.Size = new System.Drawing.Size(11, 12);
            this.lblSearchCount.TabIndex = 8;
            this.lblSearchCount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchTime);
            this.groupBox2.Location = new System.Drawing.Point(275, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 46);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查詢次數:";
            // 
            // txtSearchTime
            // 
            this.txtSearchTime.Location = new System.Drawing.Point(6, 15);
            this.txtSearchTime.Name = "txtSearchTime";
            this.txtSearchTime.Size = new System.Drawing.Size(100, 22);
            this.txtSearchTime.TabIndex = 7;
            this.txtSearchTime.Text = "35";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRangEnd);
            this.groupBox1.Controls.Add(this.txtRangStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 46);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "延遲區間(秒):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "~";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "BingSearchHelper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblSearchCount;
        private System.Windows.Forms.Button btnChangeMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkAutoMode;
    }
}

