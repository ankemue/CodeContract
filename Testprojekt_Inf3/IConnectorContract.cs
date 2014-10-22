using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Testprojekt_Inf3
{
    [ContractClassFor(typeof(IConnector))]
    internal abstract class IConnectorContract : IConnector
    {
        String ipAddress;
        Boolean connected;
        MsgBuffer b;

        [ContractInvariantMethod]
        protected void invariants()
        {
            
        }
        
        private String getServerInfos()
        {
            String hostName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry hostInfo = System.Net.Dns.GetHostEntry(hostName);
            ipAddress = hostInfo.AddressList[0].ToString();

            return ipAddress;
        }
        
       
        /*
         * manual insertion of ip and port
         */
        public void connectToServer(String ip, String port)
        {
            Contract.Requires(ip != null);
            Contract.Requires(port != null);

            
            Contract.Ensures(this.ipAddress == ip);
            Contract.Ensures(this.port == port);
        }

        public void writeInBuffer(String servermsg)
        {
            Contract.Requires(servermsg != null);
            Contract.Requires(connected == true);
            Contract.Requires(b != null);

            // Writer from Buffer
            Contract.Ensures(b[b.writer -1].equals(servermsg));
            
        }

        public void sendToServer(String clientmsg)
        {
            Contract.Requires(clientmsg != null);
            Contract.Requires(connected == true);

            Contract.Ensures(response);
        }
        

    }
}
