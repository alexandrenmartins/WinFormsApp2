namespace WinFormsRdp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            //
            // lblServer
            //
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(51, 15);
            this.lblServer.Text = "Servidor:";
            //
            // txtServer
            //
            this.txtServer.Location = new System.Drawing.Point(90, 12);
            this.txtServer.Size = new System.Drawing.Size(200, 23);
            //
            // lblUser
            //
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 44);
            this.lblUser.Size = new System.Drawing.Size(48, 15);
            this.lblUser.Text = "Usuário:";
            //
            // txtUser
            //
            this.txtUser.Location = new System.Drawing.Point(90, 41);
            this.txtUser.Size = new System.Drawing.Size(200, 23);
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 73);
            this.lblPassword.Size = new System.Drawing.Size(41, 15);
            this.lblPassword.Text = "Senha:";
            //
            // txtPassword
            //
            this.txtPassword.Location = new System.Drawing.Point(90, 70);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            //
            // chkAdmin
            //
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(90, 99);
            this.chkAdmin.Text = "Sessão /admin";
            //
            // btnConnect
            //
            this.btnConnect.Location = new System.Drawing.Point(90, 130);
            this.btnConnect.Size = new System.Drawing.Size(90, 27);
            this.btnConnect.Text = "Conectar";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            //
            // MainForm
            //
            this.ClientSize = new System.Drawing.Size(320, 175);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.btnConnect, this.chkAdmin, this.txtPassword,
                this.lblPassword, this.txtUser, this.lblUser,
                this.txtServer,   this.lblServer
            });
            this.Name = "MainForm";
            this.Text = "RDP Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
