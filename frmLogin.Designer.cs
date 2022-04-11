namespace Gestor_de_servicios_Tecnicos
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.icbtnViewPassword = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(70, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Image = ((System.Drawing.Image)(resources.GetObject("btnAbort.Image")));
            this.btnAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbort.Location = new System.Drawing.Point(196, 105);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(77, 42);
            this.btnAbort.TabIndex = 1;
            this.btnAbort.Text = "   Salir";
            this.btnAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(130, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(157, 23);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(3, 78);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(38, 15);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "label3";
            // 
            // icbtnViewPassword
            // 
            this.icbtnViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.icbtnViewPassword.FlatAppearance.BorderSize = 0;
            this.icbtnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnViewPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icbtnViewPassword.IconColor = System.Drawing.Color.Black;
            this.icbtnViewPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnViewPassword.IconSize = 23;
            this.icbtnViewPassword.Location = new System.Drawing.Point(260, 51);
            this.icbtnViewPassword.Name = "icbtnViewPassword";
            this.icbtnViewPassword.Size = new System.Drawing.Size(27, 23);
            this.icbtnViewPassword.TabIndex = 7;
            this.icbtnViewPassword.UseVisualStyleBackColor = false;
            this.icbtnViewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icbtnViewPassword_MouseDown);
            this.icbtnViewPassword.MouseLeave += new System.EventHandler(this.icbtnViewPassword_MouseLeave);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbort;
            this.ClientSize = new System.Drawing.Size(347, 158);
            this.Controls.Add(this.icbtnViewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private Button btnAbort;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label lblMessage;
        private FontAwesome.Sharp.IconButton icbtnViewPassword;
    }
}