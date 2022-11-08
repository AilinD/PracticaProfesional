namespace UI.Administrador
{
    public partial class FormularioBakup : Form
    {
        private string folder ;
        public FormularioBakup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string db = cboxBackup.Text;
                string databaseName = string.Format("{0}.bak", db);
                string save = folder;

                Services.DAL.BackupRepository.Current.CrearBackup(db, save);
                CaluculateAll(progressBar1);
                MessageBox.Show("Backup Exitoso!");
                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        private void FormularioBakup_Load(object sender, EventArgs e)
        {
            List<string> BDS = new List<string>();
            BDS.Add("SysCExpert");
            BDS.Add("PatenteFamilia");
            cboxBackup.DataSource = BDS;
            cboxBackup.DisplayMember = "Value";

        }
        private void CaluculateAll(System.Windows.Forms.ProgressBar progressBar)
        {
            progressBar.Maximum = 100000;
            progressBar.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j); //Calculation
                progressBar.PerformStep();
            }
        }


        private void lblPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private string GetSelectedPath()
        {
            string path = "";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    path= fbd.SelectedPath;
            }
            return path;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

       
            
            folder= GetSelectedPath();
            txtUbic.Text = folder;

        }

    }  
}
