using System;
using System.ComponentModel;

namespace Note
{
    partial class Note
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addbt = new System.Windows.Forms.ToolStripMenuItem();
            this.savebt = new System.Windows.Forms.ToolStripMenuItem();
            this.savabt = new System.Windows.Forms.ToolStripMenuItem();
            this.fontbt = new System.Windows.Forms.ToolStripMenuItem();
            this.colorbt = new System.Windows.Forms.ToolStripMenuItem();
            this.rtx = new System.Windows.Forms.RichTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fd = new System.Windows.Forms.FontDialog();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbt,
            this.savebt,
            this.savabt,
            this.fontbt,
            this.colorbt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addbt
            // 
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(41, 20);
            this.addbt.Text = "Add";
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // savebt
            // 
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(43, 20);
            this.savebt.Text = "Save";
            this.savebt.Click += new System.EventHandler(this.savebt_Click);
            // 
            // savabt
            // 
            this.savabt.Name = "savabt";
            this.savabt.Size = new System.Drawing.Size(60, 20);
            this.savabt.Text = "Save AS";
            this.savabt.Click += new System.EventHandler(this.savabt_Click);
            // 
            // fontbt
            // 
            this.fontbt.Name = "fontbt";
            this.fontbt.Size = new System.Drawing.Size(43, 20);
            this.fontbt.Text = "Font";
            this.fontbt.Click += new System.EventHandler(this.fontbt_Click);
            // 
            // colorbt
            // 
            this.colorbt.Name = "colorbt";
            this.colorbt.Size = new System.Drawing.Size(48, 20);
            this.colorbt.Text = "Color";
            this.colorbt.Click += new System.EventHandler(this.colorbt_Click);
            // 
            // rtx
            // 
            this.rtx.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtx.Location = new System.Drawing.Point(0, 24);
            this.rtx.Name = "rtx";
            this.rtx.Size = new System.Drawing.Size(800, 425);
            this.rtx.TabIndex = 1;
            this.rtx.Text = "";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // saveFD
            // 
            this.saveFD.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Note";
            this.Text = "Note";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Note_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addbt;
        private System.Windows.Forms.ToolStripMenuItem savebt;
        private System.Windows.Forms.ToolStripMenuItem savabt;
        private System.Windows.Forms.ToolStripMenuItem fontbt;
        private System.Windows.Forms.ToolStripMenuItem colorbt;
        private System.Windows.Forms.RichTextBox rtx;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FontDialog fd;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.SaveFileDialog saveFD;
    }
}

