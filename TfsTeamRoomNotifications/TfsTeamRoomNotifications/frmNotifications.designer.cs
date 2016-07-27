namespace TfsTeamRoomNotifications
{
   partial class frmNotifications
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotifications));
            this.contextTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconTrayMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblInitialInfo = new System.Windows.Forms.Label();
            this.menuNotifications = new System.Windows.Forms.MenuStrip();
            this.addRoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextTrayMenu.SuspendLayout();
            this.menuNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextTrayMenu
            // 
            this.contextTrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextTrayMenu.Name = "contextTrayMenu";
            this.contextTrayMenu.Size = new System.Drawing.Size(151, 52);
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.addRoomToolStripMenuItem.Text = "Add Room";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // notifyIconTrayMenu
            // 
            this.notifyIconTrayMenu.ContextMenuStrip = this.contextTrayMenu;
            this.notifyIconTrayMenu.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTrayMenu.Icon")));
            this.notifyIconTrayMenu.Text = "TFS Team Room Notifications";
            this.notifyIconTrayMenu.Visible = true;
            this.notifyIconTrayMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconTrayMenu_MouseDoubleClick);
            // 
            // lblInitialInfo
            // 
            this.lblInitialInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInitialInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialInfo.Location = new System.Drawing.Point(16, 30);
            this.lblInitialInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialInfo.Name = "lblInitialInfo";
            this.lblInitialInfo.Size = new System.Drawing.Size(877, 326);
            this.lblInitialInfo.TabIndex = 1;
            this.lblInitialInfo.Text = resources.GetString("lblInitialInfo.Text");
            // 
            // menuNotifications
            // 
            this.menuNotifications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuNotifications.Location = new System.Drawing.Point(0, 0);
            this.menuNotifications.Name = "menuNotifications";
            this.menuNotifications.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuNotifications.Size = new System.Drawing.Size(909, 28);
            this.menuNotifications.TabIndex = 2;
            this.menuNotifications.Text = "menuStrip1";
            // 
            // addRoomToolStripMenuItem1
            // 
            this.addRoomToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem2,
            this.minimizeToTrayToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.addRoomToolStripMenuItem1.Name = "addRoomToolStripMenuItem1";
            this.addRoomToolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.addRoomToolStripMenuItem1.Text = "Notifier";
            // 
            // addRoomToolStripMenuItem2
            // 
            this.addRoomToolStripMenuItem2.Name = "addRoomToolStripMenuItem2";
            this.addRoomToolStripMenuItem2.Size = new System.Drawing.Size(194, 26);
            this.addRoomToolStripMenuItem2.Text = "Add Room";
            this.addRoomToolStripMenuItem2.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "test data check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInitialInfo);
            this.Controls.Add(this.menuNotifications);
            this.MainMenuStrip = this.menuNotifications;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFS Team Room Notifications";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNotifications_FormClosing);
            this.Move += new System.EventHandler(this.frmTray_Move);
            this.contextTrayMenu.ResumeLayout(false);
            this.menuNotifications.ResumeLayout(false);
            this.menuNotifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ContextMenuStrip contextTrayMenu;
      private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.NotifyIcon notifyIconTrayMenu;
        private System.Windows.Forms.Label lblInitialInfo;
        private System.Windows.Forms.MenuStrip menuNotifications;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

