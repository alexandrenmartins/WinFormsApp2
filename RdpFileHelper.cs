using System;
using System.IO;

namespace WinFormsRdp
{
    internal static class RdpFileHelper
    {
        /// <summary>Cria um .rdp temporário com as opções mínimas.</summary>
        public static string CreateTempRdpFile(string server, string user, bool asAdmin)
        {
            var file = Path.Combine(Path.GetTempPath(), $"{server}_{Guid.NewGuid():N}.rdp");

            var lines = new[]
            {
                $"full address:s:{server}",
                $"username:s:{user}",
                $"administrative session:i:{(asAdmin ? 1 : 0)}",
                "screen mode id:i:2"      // iniciar minimizado (opcional)
            };

            File.WriteAllLines(file, lines);
            return file;
        }
    }
}