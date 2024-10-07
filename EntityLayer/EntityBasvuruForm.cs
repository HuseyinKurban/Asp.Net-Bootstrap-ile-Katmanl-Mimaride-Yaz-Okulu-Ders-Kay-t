using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        private int basdersid;
        private int basogrid;
        private string ad;
        private string soyad;
        private string dersad;

        public int BASVURUID
        {
            get { return basvuruid; }
            set { basvuruid = value; }
        }
        public int BASDERSID
        {
            get { return basdersid; }
            set { basdersid = value; }
        }
        public int BASOGRID
        {
            get { return basogrid; }
            set { basogrid = value; }
        }

        public string OGRAD
        {
            get { return ad; }
            set { ad = value; }
        }

        public string DERSAD
        {
            get { return dersad; }
            set { dersad = value; }
        }

    }
}
