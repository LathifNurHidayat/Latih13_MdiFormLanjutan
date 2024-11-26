namespace Latih13_MdiFormLanjutan
{
    public partial class DataPegawai : Form
    {
        public DataPegawai()
        {
            InitializeComponent();
            ListData();

            List<string> gender = new List<string> { "Pilih Jenis Kelamin", "Laki-laki", "Perempuan" };
            JenisKelaminCombo.DataSource = gender;
      /*      JenisKelaminCombo.Items.Add("Laki-laki");
            JenisKelaminCombo.Items.Add("Perempuan");*/

        }

        public void ListData()
        {
            using var db = new ConnDbContext();
            var pegawai = db.TB_Employee.ToList();
            dataGridView1.DataSource = pegawai;
            tabControl1.SelectedIndex = 0;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewPegawai();
        }

        public void NewPegawai()
        {
            var newPegawai = new PegawaiModel();
            using var db = new ConnDbContext();
            db.TB_Employee.Add(newPegawai);
            db.SaveChanges();

            ShowInput(newPegawai);
        }

        public void ShowInput(PegawaiModel pegawai)
        {
            IdText.Text = pegawai.id.ToString();
            NamaText.Text = pegawai.nama;
            JenisKelaminCombo.SelectedItem = pegawai.jenis_kelamin;
            TanggalLahirPicker.Value = pegawai.tgl_lahir;
            AlamatText.Text = pegawai.alamat;

            tabControl1.SelectedIndex = 1;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var idPegawai = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            if (string.IsNullOrEmpty(idPegawai))
                return;

            using var db = new ConnDbContext();
            var pegawai = db.TB_Employee.Find(int.Parse(idPegawai));
            if (pegawai != null)
            {
                ShowInput(pegawai);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData();
            ListData();
        }

        public void SaveData()
        {
            using var db = new ConnDbContext();
            var pegawai = db.TB_Employee.Find(int.Parse(IdText.Text));

            if (pegawai != null)
            {
                pegawai.nama = NamaText.Text;
                pegawai.jenis_kelamin = JenisKelaminCombo.SelectedItem.ToString();
                pegawai.tgl_lahir = TanggalLahirPicker.Value;
                pegawai.alamat = AlamatText.Text;

                db.SaveChanges();
            }
        }
    }
}
