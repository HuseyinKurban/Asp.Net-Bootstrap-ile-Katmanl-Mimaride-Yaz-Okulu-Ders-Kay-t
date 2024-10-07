using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtbrans;

        public int OGRTID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }
        public string OGRTAD
        {
            get { return ogrtad; }
            set { ogrtad = value; }
        }
        public int OGRTBRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }
    }
}
