﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);

            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p != null)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
    }
}