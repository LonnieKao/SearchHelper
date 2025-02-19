namespace BingSearchHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class CustomMessageBox : Form
    {
        private Timer timer;
        private int countdown = 10; // Countdown in seconds

        public bool Result { get; private set; } = false; // Default to "Yes"

        public CustomMessageBox()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Confirm";
            this.Size = new System.Drawing.Size(300, 150);

            Label messageLabel = new Label()
            {
                Text = "Do you want to proceed? Auto Yes in 10 seconds.",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };
            this.Controls.Add(messageLabel);

            Button yesButton = new Button()
            {
                Text = "Yes",
                Location = new System.Drawing.Point(50, 70),
                DialogResult = DialogResult.OK
            };
            yesButton.Click += (s, e) => { Result = true; this.Close(); };
            this.Controls.Add(yesButton);

            Button noButton = new Button()
            {
                Text = "No",
                Location = new System.Drawing.Point(150, 70),
                DialogResult = DialogResult.Cancel
            };
            noButton.Click += (s, e) => { Result = false; this.Close(); };
            this.Controls.Add(noButton);

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            this.Text = $"Confirm ({countdown}s)";
            if (countdown == 0)
            {
                timer.Stop();
                Result = true; // Auto select "Yes"
                this.Close();
            }
        }

        public static bool Show(string message)
        {
            using (CustomMessageBox box = new CustomMessageBox())
            {
                box.ShowDialog();
                return box.Result;
            }
        }
    }
}
