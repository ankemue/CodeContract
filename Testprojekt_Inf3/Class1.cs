using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt_Inf3
{
    [ContractClassFor(typeof(Parser))]
    class Parser
    {
        MsgBuffer b;
        String msg;
        Array[] values;
        Manager m;

        public String readFromBuffer()
        {
            Contract.Requires(b != null);

            Contract.Ensures(msg != null);
            Contract.Ensures(b[b.reader - 1] ==null);

            return msg;
        }
        public void parserRulePlayer()
        {
            Contract.Requires(msg != null);

            Contract.Ensures(values[] != null);
        }
        public void chooseManagerFunction()
        {
            Contract.Requires(values.Length > 0);
            Contract.Requires(msg != null);

            Contract.Ensures(m.players[] != null);
        }
    }
}
