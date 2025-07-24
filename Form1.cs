using MSTSCLib;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Defina servidor e usuário
            rdpControl.Domain = "EC2AMAZ-MAA7NS1";
            rdpControl.Server = "52.203.146.198";
            rdpControl.UserName = "ASPEC/38980665334";

            // Configurações avançadas (senha em texto claro)
            var adv = (IMsRdpClientAdvancedSettings)rdpControl.AdvancedSettings;
            adv.ClearTextPassword = "9876@Alex";

            // Tamanho e cor da área de trabalho remota
            rdpControl.DesktopWidth = Screen.PrimaryScreen.Bounds.Width;
            rdpControl.DesktopHeight = Screen.PrimaryScreen.Bounds.Height;
            //adv.ColorDepth = 32;


            // Inicia a conexão
            rdpControl.Connect();
            MessageBox.Show($"Conexão(result): {rdpControl.Connected}");
            //rdpControl.Show();
            // Verifica se a conexão foi bem-sucedida
            //if (rdpControl.Connected)
            //{
            //    MessageBox.Show("Conexão bem-sucedida!");
            //}
            //else
            //{
            //    MessageBox.Show("Falha na conexão.");

            //}
        }

        private void rdpControl_OnConnecting(object sender, EventArgs e)
        {

        }
    }
}
