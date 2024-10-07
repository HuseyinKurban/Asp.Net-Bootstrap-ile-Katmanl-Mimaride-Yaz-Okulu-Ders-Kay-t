using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLBasvuruForm
    {
        public static List<EntityBasvuruForm> BllBasvuruListele()
        {
            return DALBasvuruForm.BasvuruListesi();
        }
    }
}
