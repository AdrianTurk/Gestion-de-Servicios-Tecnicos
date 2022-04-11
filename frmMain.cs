namespace Gestor_de_servicios_Tecnicos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            btnChangeUser_Click(sender, e);
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            frmLogin loginDialog = new();
            loginDialog.ShowDialog();
            if (loginDialog.LoguedUser is not null)
            {
                this.lblUserName.Text = loginDialog.LoguedUser.Name;
                this.lblUserName.Text += 
                    (loginDialog.LoguedUser.Grants == UserGrants.ROL_ADMIN) ? " - ADMINISTRADOR" :
                    (loginDialog.LoguedUser.Grants == UserGrants.ROL_TECHNIC) ? " - TECNICO" : "";
            }
            else
            {
                Application.Exit();
            }
        }
    }
}