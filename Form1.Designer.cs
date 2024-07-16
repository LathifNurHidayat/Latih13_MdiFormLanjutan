namespace Latih13_MdiFormLanjutan
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            masterDataToolStripMenuItem = new ToolStripMenuItem();
            pegawaiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterDataToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1013, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterDataToolStripMenuItem
            // 
            masterDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pegawaiToolStripMenuItem });
            masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            masterDataToolStripMenuItem.Size = new Size(124, 29);
            masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // pegawaiToolStripMenuItem
            // 
            pegawaiToolStripMenuItem.Name = "pegawaiToolStripMenuItem";
            pegawaiToolStripMenuItem.Size = new Size(270, 34);
            pegawaiToolStripMenuItem.Text = "Pegawai";
            pegawaiToolStripMenuItem.Click += pegawaiToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 607);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mdi Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterDataToolStripMenuItem;
        private ToolStripMenuItem pegawaiToolStripMenuItem;
    }
}
