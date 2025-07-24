using System.Diagnostics;

namespace WinFormsRdp
{
    internal static class RdpLauncher
    {
        /// <summary>Dispara o mstsc.exe sem prompt.</summary>
        public static void StartRdp(string rdpFile)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "mstsc.exe",
                Arguments = $"\"{rdpFile}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Process.Start(psi);
        }
    }
}