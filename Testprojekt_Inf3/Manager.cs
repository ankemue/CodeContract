using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Collections.ArrayList;
using System.Collections;

namespace Testprojekt_Inf3
{
    [ContractClassFor(typeof(Manager))]
    class Manager
    {
        ArrayList players;
        Player p;
        Challenge ch;
        Frontend f;
        ArrayList dragons;
        Chatbuffer cb;
        Map m;

        public void sendToConnector(String msg)
        {
            Contract.Requires(msg != null);

            Contract.Ensures(f.refreshed == true);
        }
        public void store()
        {

        }
    }
}
