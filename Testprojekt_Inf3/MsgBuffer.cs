using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Testprojekt_Inf3
{
     [ContractClassFor(typeof(MsgBuffer))]
    class MsgBuffer
    {
        bool full;
        Array[] buffer;
        int writer;
        int reader;
        String msg;

        public void add(String serverMsg)
        {
            Contract.Ensures(this != null);
            Contract.Ensures(serverMsg.Equals(buffer[writer -1]));
        }
        public String take()
        {
            Contract.Requires(buffer[reader] != null);
            Contract.Requires(msg != null);
            return msg;
        }
        public bool howDoYouFeelBuffer()
        {
            Contract.Ensures(full == true || full == false);
            return full;

        }
    }

}
