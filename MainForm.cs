using System;
using System.Windows.Forms;
using AxMSTSCLib;            // ActiveX
using MSTSCLib;             // Interfaces

namespace WinFormsRdp
{
    public partial class MainForm : Form
    {
        private readonly AxMsRdpClient11NotSafeForScripting rdp;   // controle RDP

        public MainForm()
        {
            InitializeComponent();

            // ---------- valores mockados ----------
            txtServer.Text = "52.203.146.198";
            txtUser.Text = @"ASPEC\05037031330";
            txtPassword.Text = "9876@Aspec";

            // ---------- cria e adiciona o ActiveX ----------
            rdp = new AxMsRdpClient11NotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)rdp).BeginInit();
            rdp.Dock = DockStyle.Fill;
            rdp.Visible = false;                 // só mostra depois de conectar
            Controls.Add(rdp);
            ((System.ComponentModel.ISupportInitialize)rdp).EndInit();

            // eventos para feedback
            rdp.OnConnected += (_, __) => OnRdpConnected();
            rdp.OnDisconnected += (_, e) =>
                MessageBox.Show($"Desconectado (código {e.discReason})");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // já estão mockados, mas pode ler dos TextBox
            rdp.Server = txtServer.Text.Trim();        // 52.203.146.198
            rdp.Domain = "ASPEC";
            rdp.UserName = txtUser.Text.Trim();          // 05037031330

            // senha clara
            ((IMsRdpClientAdvancedSettings)rdp.AdvancedSettings)
                .ClearTextPassword = txtPassword.Text;

            // usa todo o tamanho do controle
            rdp.DesktopWidth = rdp.Width;
            rdp.DesktopHeight = rdp.Height;

            try { rdp.Connect(); }
            catch (Exception ex)
            { MessageBox.Show("Falha: " + ex.Message); }
        }

        private void OnRdpConnected()
        {
            // ----------- esconde os controles de login -----------
            Control[] toHide =
            {
        lblServer!, txtServer!,
        lblUser!,   txtUser!,
        lblPassword!, txtPassword!,
        chkAdmin!,  btnConnect!
    };

            foreach (var c in toHide)
                c.Visible = false;

            // ----------- mostra o desktop remoto -----------
            rdp.Visible = true;
            WindowState = FormWindowState.Maximized;
        }
    }
}