using System;
using System.Diagnostics.Contracts;
using Testprojekt_Inf3;


[ContractClass(typeof(IConnectorContract))]
public  interface IConnector
{
    public void connectToServer(String ip, String port);

    public void writeInBuffer(String servermsg);

    public void sendToServer(String clientmsg);
   
}
