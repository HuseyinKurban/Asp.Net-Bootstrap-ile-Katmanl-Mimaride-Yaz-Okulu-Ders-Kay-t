using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALBasvuruForm
    {
        public static List<EntityBasvuruForm> BasvuruListesi()
        {
            List<EntityBasvuruForm> degerler = new List<EntityBasvuruForm>();
            SqlCommand komut2 = new SqlCommand("SELECT BASVURUID, OGRID, TBLDERSLER.DERSID , OGRAD + ' ' + OGRSOYAD AS 'AD', DERSAD FROM TBLBASVURUFORM \r\nINNER JOIN TBLOGRENCI\r\nON TBLOGRENCI.OGRID = TBLBASVURUFORM.OGRENCIID \r\nINNER JOIN TBLDERSLER\r\nON TBLDERSLER.DERSID = TBLBASVURUFORM.DERSID", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuruForm ent = new EntityBasvuruForm();
                ent.BASVURUID = Convert.ToInt32(dr["BASVURUID"].ToString());
                ent.BASOGRID = Convert.ToInt32(dr["OGRID"].ToString());
                ent.BASDERSID = Convert.ToInt32(dr["DERSID"].ToString());
                ent.OGRAD = dr["AD"].ToString(); 
                ent.DERSAD = dr["DERSAD"].ToString();

                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
    }
}
