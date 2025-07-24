using CredentialManagement;
using System;
using System.Net;

namespace WinFormsRdp
{
    internal static class CredentialHelper
    {
        /// <summary>Grava ou atualiza a credencial do servidor RDP.</summary>
        public static void SaveCredential(string server, string domainUser, string password)
        {
            var cred = new Credential
            {
                Target = $"TERMSRV/{server}",
                Username = domainUser,
                Password = password,
                PersistanceType = PersistanceType.LocalComputer
            };

            if (!cred.Save())
                throw new InvalidOperationException(
                    new System.ComponentModel.Win32Exception().Message);
        }
    }
}