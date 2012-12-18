using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace PanoptoAPITest
{
    /// <summary>
    /// This sample shows how to use cookie-based authentication with the Panopto PublicAPI
    /// </summary>
    class Program
    {
        static bool hasBeenInitialized = false;

        static void Main(string[] args)
        {
            try
            {
                // Only needed to override validation for servers with self-signed certificates
                EnsureCertificateValidation();

                // Login to server
                Console.WriteLine("Authenticating...");
                Auth.AuthClient AC = new Auth.AuthClient();

                if (!AC.LogOnWithPassword("admin", "foobar"))
                {
                    Console.WriteLine("Failed to login!");
                    Environment.Exit(1);
                }

                // Make PublicAPI calls
                Console.WriteLine("Making ListRecorders call...");
                RemoteRecorderManagement.RemoteRecorderManagementClient RMC = new RemoteRecorderManagement.RemoteRecorderManagementClient();
                RemoteRecorderManagement.ListRecordersResponse RR = RMC.ListRecorders(null, new RemoteRecorderManagement.Pagination() { MaxNumberResults = 255 }, RemoteRecorderManagement.RecorderSortField.Name);
                Console.WriteLine("Made ListRecorders call");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Ensures that our custom certificate validation has been applied
        /// </summary>
        public static void EnsureCertificateValidation()
        {
            if (!hasBeenInitialized)
            {
                ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(CustomCertificateValidation);
                hasBeenInitialized = true;
            }
        }

        /// <summary>
        /// Ensures that server certificate is authenticated
        /// </summary>
        private static bool CustomCertificateValidation(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            return true;
        }

    }
}
