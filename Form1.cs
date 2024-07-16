namespace Latih13_MdiFormLanjutan
{
    public partial class Form1 : Form
    {

         Form currentChildForm = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChil(new DataPegawai()); 
        }

        private void FormChil(Form formAnak)
        {
            if ( currentChildForm != null)
            {
                currentChildForm.Hide();
            }

            currentChildForm = formAnak;
            currentChildForm.MdiParent = this;
            formAnak.Show();
        }
    }
}
