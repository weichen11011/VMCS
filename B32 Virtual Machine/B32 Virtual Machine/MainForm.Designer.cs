namespace B32_Virtual_Machine
{
    partial class MainForm
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
            b32Screen1 = new B32Screen();
            msMainMenu = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            pnlRegisters = new Panel();
            lblRegisters = new Label();
            openFileDialog1 = new OpenFileDialog();
            msMainMenu.SuspendLayout();
            pnlRegisters.SuspendLayout();
            SuspendLayout();
            // 
            // b32Screen1
            // 
            b32Screen1.BackColor = Color.Black;
            b32Screen1.Dock = DockStyle.Fill;
            b32Screen1.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            b32Screen1.ForeColor = Color.Black;
            b32Screen1.Location = new Point(0, 28);
            b32Screen1.Margin = new Padding(2, 3, 2, 3);
            b32Screen1.Name = "b32Screen1";
            b32Screen1.ScreenMemoryLocation = (ushort)40960;
            b32Screen1.Size = new Size(642, 319);
            b32Screen1.TabIndex = 0;
            // 
            // msMainMenu
            // 
            msMainMenu.ImageScalingSize = new Size(20, 20);
            msMainMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            msMainMenu.Location = new Point(0, 0);
            msMainMenu.Name = "msMainMenu";
            msMainMenu.Size = new Size(642, 28);
            msMainMenu.TabIndex = 1;
            msMainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(47, 24);
            toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // pnlRegisters
            // 
            pnlRegisters.Controls.Add(lblRegisters);
            pnlRegisters.Dock = DockStyle.Bottom;
            pnlRegisters.Location = new Point(0, 293);
            pnlRegisters.Name = "pnlRegisters";
            pnlRegisters.Size = new Size(642, 54);
            pnlRegisters.TabIndex = 2;
            // 
            // lblRegisters
            // 
            lblRegisters.Dock = DockStyle.Fill;
            lblRegisters.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisters.Location = new Point(0, 0);
            lblRegisters.Name = "lblRegisters";
            lblRegisters.Size = new Size(642, 54);
            lblRegisters.TabIndex = 0;
            lblRegisters.Text = "label1";
            lblRegisters.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "B32";
            openFileDialog1.Filter = "B32 Files | *.B32";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 347);
            Controls.Add(pnlRegisters);
            Controls.Add(b32Screen1);
            Controls.Add(msMainMenu);
            MainMenuStrip = msMainMenu;
            Name = "MainForm";
            Text = "Form1";
            msMainMenu.ResumeLayout(false);
            msMainMenu.PerformLayout();
            pnlRegisters.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private B32Screen b32Screen1;
        private MenuStrip msMainMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private Panel pnlRegisters;
        private Label lblRegisters;
        private OpenFileDialog openFileDialog1;
    }
}