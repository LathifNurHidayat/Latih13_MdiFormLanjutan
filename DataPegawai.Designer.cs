namespace Latih13_MdiFormLanjutan
{
    partial class DataPegawai
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            NewButton = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            SaveButton = new Button();
            panel2 = new Panel();
            TanggalLahirPicker = new DateTimePicker();
            AlamatText = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            NamaText = new TextBox();
            JenisKelaminCombo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            IdText = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(782, 493);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(NewButton);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(774, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Data Pegawai";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            NewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NewButton.BackColor = Color.LimeGreen;
            NewButton.Location = new Point(654, 408);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(112, 34);
            NewButton.TabIndex = 1;
            NewButton.Text = "New Data";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(760, 396);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SaveButton);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(774, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Pegawai";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.DodgerBlue;
            SaveButton.ForeColor = SystemColors.ButtonHighlight;
            SaveButton.Location = new Point(650, 401);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(107, 36);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(TanggalLahirPicker);
            panel2.Controls.Add(AlamatText);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(390, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 376);
            panel2.TabIndex = 1;
            // 
            // TanggalLahirPicker
            // 
            TanggalLahirPicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TanggalLahirPicker.Location = new Point(15, 49);
            TanggalLahirPicker.Name = "TanggalLahirPicker";
            TanggalLahirPicker.Size = new Size(341, 31);
            TanggalLahirPicker.TabIndex = 1;
            // 
            // AlamatText
            // 
            AlamatText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AlamatText.Location = new Point(15, 133);
            AlamatText.Multiline = true;
            AlamatText.Name = "AlamatText";
            AlamatText.Size = new Size(341, 78);
            AlamatText.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 105);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 8;
            label5.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 21);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 6;
            label4.Text = "Tanggal Lahir";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(NamaText);
            panel1.Controls.Add(JenisKelaminCombo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IdText);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 376);
            panel1.TabIndex = 0;
            // 
            // NamaText
            // 
            NamaText.Location = new Point(15, 133);
            NamaText.Name = "NamaText";
            NamaText.Size = new Size(341, 31);
            NamaText.TabIndex = 5;
            // 
            // JenisKelaminCombo
            // 
            JenisKelaminCombo.FormattingEnabled = true;
            JenisKelaminCombo.Location = new Point(15, 214);
            JenisKelaminCombo.Name = "JenisKelaminCombo";
            JenisKelaminCombo.Size = new Size(341, 33);
            JenisKelaminCombo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 186);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 105);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // IdText
            // 
            IdText.Location = new Point(15, 49);
            IdText.Name = "IdText";
            IdText.ReadOnly = true;
            IdText.Size = new Size(341, 31);
            IdText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Id Pegawai";
            // 
            // DataPegawai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 493);
            Controls.Add(tabControl1);
            Name = "DataPegawai";
            Text = "DataPegawai";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button NewButton;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button SaveButton;
        private Panel panel2;
        private TextBox AlamatText;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox IdText;
        private Label label1;
        private DateTimePicker TanggalLahirPicker;
        private ComboBox JenisKelaminCombo;
        private TextBox NamaText;
    }
}