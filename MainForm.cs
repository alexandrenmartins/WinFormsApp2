using System;
using System.Windows.Forms;
using AxMSTSCLib;      // ActiveX wrapper
using MSTSCLib;       // Interfaces do RDP

namespace WinFormsRdp
{
    public partial class MainForm : Form
    {
        private AxMsRdpClient10NotSafeForScripting rdp;   // <<< use 11 se existir

        public MainForm()
        {
            InitializeComponent();

            // valores mockados
            txtServer.Text = "52.203.146.198";
            txtUser.Text = @"ASPEC\05037031330";
            txtPassword.Text = "9876@Aspec";
        }

        // ---------- cria o ActiveX quando o Form carrega ----------
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                rdp = new AxMsRdpClient10NotSafeForScripting();   // <<< use 11 se existir
                ((System.ComponentModel.ISupportInitialize)rdp).BeginInit();
                rdp.Dock = DockStyle.Fill;
                rdp.Visible = false;
                Controls.Add(rdp);
                ((System.ComponentModel.ISupportInitialize)rdp).EndInit();

                rdp.CreateControl();   // força inicialização COM
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falhou ao criar ActiveX RDP:\n\n" + ex,
                                "Init RDP",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Close();
                return;
            }

            // eventos de feedback
            rdp.OnConnected += (_, __) => OnRdpConnected();
            rdp.OnDisconnected += (_, e2) =>
                MessageBox.Show($"Desconectado (código {e2.discReason})");
        }

        // ---------- botão Conectar ----------
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // –– credenciais / host ––
            rdp.Server = txtServer.Text.Trim();      // 52.203.146.198
            rdp.Domain = "ASPEC";
            rdp.UserName = txtUser.Text.Trim();        // 05037031330

            // –– senha clara ––
            var adv7 = (IMsRdpClientAdvancedSettings7)rdp.AdvancedSettings;
            adv7.ClearTextPassword = txtPassword.Text;

            // –– habilita NLA / CredSSP ––
            adv7.EnableCredSspSupport = true;          // envia CredSSP
            adv7.AuthenticationLevel = 2;             // 0 = none, 1 = optional, 2 = require

            // –– ativa SmartSizing para escalar a imagem ––
            adv7.SmartSizing = true;

            // define uma resolução inicial razoável (será escalada depois)
            rdp.DesktopWidth = 1920;
            rdp.DesktopHeight = 1080;

            try
            {
                rdp.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar:\n" + ex.Message,
                                "RDP",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // ---------- ao conectar, esconde campos ----------
        private void OnRdpConnected()
        {
            Control[] toHide =
            {
                lblServer!, txtServer!,
                lblUser!,   txtUser!,
                lblPassword!, txtPassword!,
                chkAdmin!,  btnConnect!
            };
            foreach (var c in toHide) c.Visible = false;

            rdp.Visible = true;
            WindowState = FormWindowState.Maximized;
        }
    }
}