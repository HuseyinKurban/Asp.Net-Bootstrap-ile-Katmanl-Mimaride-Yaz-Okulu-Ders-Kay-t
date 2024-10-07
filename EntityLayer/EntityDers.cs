using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private string dersad;
        private int min;
        private int max;
        private int id;

        public string DERSAD
        {
            get { return dersad; }
            set { dersad = value; }
        }
        public int MIN
        {
            get { return min; }
            set { min = value; }
        }
        public int MAX
        {
            get { return max; }
            set { max = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
