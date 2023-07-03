namespace CarrosEx
{
    public partial class FormPrincipal : Form
    {
        private System.Windows.Forms.Button btnTeste;

        public FormPrincipal()
        {
            InitializeComponent();

            btnTeste = new System.Windows.Forms.Button();
            btnTeste.Text = "Clique aqui";
            btnTeste.Click += BtnTeste_Click;
            Controls.Add(btnTeste);
        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }
    }
}
