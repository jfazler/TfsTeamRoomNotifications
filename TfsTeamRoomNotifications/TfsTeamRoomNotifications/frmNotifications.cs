using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TfsTeamRoomNotifications
{
    public partial class frmNotifications : Form
    {
        private readonly Timer _timer = new Timer();
        // TODO -- remove -- testing with random notifications
        private readonly Random _rnd = new Random(Environment.TickCount);
        private const int minInterval = 15000;
        private const int maxInterval = 60000;

        private TfsRoom tfsRoom = new TfsRoom();

        public frmNotifications()
        {
            InitializeComponent();

            // TODO -- remove -- testing with random notifications
            _timer.Tick += _timer_Tick;
            _timer.Interval = _rnd.Next(minInterval, maxInterval);
            _timer.Start();
        }

        // TODO -- remove -- testing with random notifications
        private void _timer_Tick(object sender, EventArgs e)
        {
            check();
        }

        private void frmTray_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                hideApplication();
            }
        }

        private void frmNotifications_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                hideApplication();
                e.Cancel = true;
            }
            else
            {
                // TODO -- remove -- testing with random notifications
                _timer.Stop();
            }
        }

        private void check()
        {
            if (!tfsRoom.busy)
            {
                tfsRoom.checkData().ContinueWith(
                    t => notifyIconTrayMenu.ShowBalloonTip(1000, "Title here", string.Concat("Message:", t.Result), ToolTipIcon.Info));
            }

        }

        private void hideApplication()
        {
            this.Hide();
        }

        private void showApplication()
        {
            this.Show();
        }

        private void exitApplication()
        {
            Application.Exit();
        }

        #region Simple Basic Handlers
        private void notifyIconTrayMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showApplication();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showApplication();
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideApplication();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO - display about information
            MessageBox.Show("About information not added yet.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
        }

        #endregion Basic Event Handlers
    }
}
