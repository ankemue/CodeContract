using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Testprojekt_Inf3
{
     [ContractClassFor(typeof(Frontend))]
    class Frontend
    {

        Manager m;
        bool refreshed;

        public Map refresh()
        {
            m.Map map;
            Contract.Requires(m != null);

            Contract.Ensures(refreshed == true);
            return map;
        }
    }
}
