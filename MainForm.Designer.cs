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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblServer = new();
            lblUser = new();
            lblPassword = new();
            txtServer = new();
            txtUser = new();
            txtPassword = new();
            btnConnect = new();
            chkAdmin = new();

            SuspendLayout();
            // lblServer
            lblServer.AutoSize = true;
            lblServer.Location = new(12, 15);
            lblServer.Text = "Servidor:";
            // txtServer
            txtServer.Location = new(90, 12);
            txtServer.Size = new(200, 23);
            // lblUser
            lblUser.AutoSize = true;
            lblUser.Location = new(12, 44);
            lblUser.Text = "Usuário:";
            // txtUser
            txtUser.Location = new(90, 41);
            txtUser.Size = new(200, 23);
            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new(12, 73);
            lblPassword.Text = "Senha:";
            // txtPassword
            txtPassword.Location = new(90, 70);
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new(200, 23);
            // chkAdmin
            chkAdmin.AutoSize = true;
            chkAdmin.Location = new(90, 99);
            chkAdmin.Text = "Sessão /admin";
            // btnConnect
            btnConnect.Location = new(90, 130);
            btnConnect.Size = new(90, 27);
            btnConnect.Text = "Conectar";
            btnConnect.Click += btnConnect_Click;
            // MainForm
            ClientSize = new(320, 175);
            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblServer, txtServer,
                lblUser,   txtUser,
                lblPassword, txtPassword,
                chkAdmin,
                btnConnect
            });
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Text = "RDP Launcher";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
