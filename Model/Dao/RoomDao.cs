using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
   public class RoomDao
    {
        QuanLyKyTucXaDb db = null;
        public RoomDao()
        {
            db = new QuanLyKyTucXaDb(); 
                  
        }
        public List<Phong> ListAll()
        {
            return db.Phongs.ToList();
        }
        public void Insert()
        {

        }
    }
}
