using System;
using System.Runtime.InteropServices;   // para SEHException
using System.Windows.Forms;

namespace WinFormsRdp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            // aplica estilos de aplicativo (High DPI, fontes, etc.)
            ApplicationConfiguration.Initialize();

            try
            {
                // formulário principal da aplicação
                Application.Run(new MainForm());
            }
            // exceções nativas (COM/ActiveX) entram aqui
            catch (SEHException seh)
            {
                ShowFatal($"SEHException (0x{seh.ErrorCode:X8})\n\n{seh}");
            }
            // quaisquer outras exceções .NET não tratadas
            catch (Exception ex)
            {
                ShowFatal("Unhandled Exception\n\n" + ex);
            }
        }

        /// <summary>Mostra mensagem de erro fatal e grava no console.</summary>
        private static void ShowFatal(string text)
        {
            // útil quando o app é iniciado via dotnet CLI
            Console.Error.WriteLine(text);

            // caixa de diálogo visível ao usuário
            MessageBox.Show(text,
                            "Erro fatal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}