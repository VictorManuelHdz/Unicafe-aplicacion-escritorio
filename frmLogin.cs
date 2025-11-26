namespace pryCafeteriaUTHH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                clsLogin login = new clsLogin();
                login.Usuario = txtUsuario.Text;
                login.Password = txtPassword.Text;
                if (login.ValidarAcceso())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                return;
            }
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
