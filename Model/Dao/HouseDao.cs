using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class HouseDao
    {
        QuanLyKyTucXaDb db = null;
        public HouseDao()
        {
            db = new QuanLyKyTucXaDb();

        }
        public List<KhuNha> ListAll()
        {
            return db.KhuNhas.ToList();
        }
    }
}
