using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_servicios_Tecnicos
{
    public partial class frmLogin : Form
    {
        private User? loguedUser;

        public User? LoguedUser{
            get{ return loguedUser; }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TODO: Programar la logica de logueo
            
            while (txtUserName.Text.ToLower() != "admin" || txtPassword.Text != "Admin")
            {
                lblMessage.Text = "El usuario/password ingresado, no es correcto, intente\nnuevamente";
                return;
            }
            loguedUser = new();
            loguedUser.Name = txtUserName.Text;
            loguedUser.Grants=UserGrants.ROL_ADMIN;
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            icbtnViewPassword.Parent = txtPassword;
            icbtnViewPassword.Dock = DockStyle.Right;

        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void icbtnViewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void icbtnViewPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loguedUser is null)
                Application.Exit();
        }
    }
}
