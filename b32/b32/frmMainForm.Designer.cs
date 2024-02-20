namespace b32
{
    partial class frmMainForm
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
            txtSourceFileName = new TextBox();
            txtOutputFileName = new TextBox();
            txtOrigin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnassemble = new Button();
            btnSourceBrowse = new Button();
            btnoutputbrowse = new Button();
            fdDestinationFile = new OpenFileDialog();
            fdSourceFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // txtSourceFileName
            // 
            txtSourceFileName.Location = new Point(103, 20);
            txtSourceFileName.Name = "txtSourceFileName";
            txtSourceFileName.Size = new Size(100, 23);
            txtSourceFileName.TabIndex = 0;
            // 
            // txtOutputFileName
            // 
            txtOutputFileName.Location = new Point(103, 49);
            txtOutputFileName.Name = "txtOutputFileName";
            txtOutputFileName.Size = new Size(100, 23);
            txtOutputFileName.TabIndex = 1;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(103, 83);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(100, 23);
            txtOrigin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Sourcefile:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 57);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Outputfile:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 91);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Origin:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 91);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 6;
            label4.Text = "$";
            // 
            // btnassemble
            // 
            btnassemble.Location = new Point(103, 163);
            btnassemble.Name = "btnassemble";
            btnassemble.Size = new Size(75, 23);
            btnassemble.TabIndex = 7;
            btnassemble.Text = "Assemble!";
            btnassemble.UseVisualStyleBackColor = true;
            btnassemble.Click += btnassemble_Click;
            // 
            // btnSourceBrowse
            // 
            btnSourceBrowse.Location = new Point(234, 20);
            btnSourceBrowse.Name = "btnSourceBrowse";
            btnSourceBrowse.Size = new Size(75, 23);
            btnSourceBrowse.TabIndex = 8;
            btnSourceBrowse.Text = "Browse...";
            btnSourceBrowse.UseVisualStyleBackColor = true;
            btnSourceBrowse.Click += btnsourcebrowse_Click;
            // 
            // btnoutputbrowse
            // 
            btnoutputbrowse.Location = new Point(234, 53);
            btnoutputbrowse.Name = "btnoutputbrowse";
            btnoutputbrowse.Size = new Size(75, 23);
            btnoutputbrowse.TabIndex = 9;
            btnoutputbrowse.Text = "Browse...";
            btnoutputbrowse.UseVisualStyleBackColor = true;
            btnoutputbrowse.Click += btnoutputbrowse_Click;
            // 
            // fdDestinationFile
            // 
            fdDestinationFile.DefaultExt = " B32";
            fdDestinationFile.Filter = " B32 Files|*.B32";
            // 
            // fdSourceFile
            // 
            fdSourceFile.CheckFileExists = false;
            fdSourceFile.DefaultExt = "asm";
            fdSourceFile.Filter = "B32 Assembly Files|*.asm";
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 208);
            Controls.Add(btnoutputbrowse);
            Controls.Add(btnSourceBrowse);
            Controls.Add(btnassemble);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOrigin);
            Controls.Add(txtOutputFileName);
            Controls.Add(txtSourceFileName);
            Name = "frmMainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSourceFileName;
        private TextBox txtOutputFileName;
        private TextBox txtOrigin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnassemble;
        private Button btnSourceBrowse;
        private Button btnoutputbrowse;
        private OpenFileDialog fdDestinationFile;
        private OpenFileDialog fdSourceFile;
    }
}