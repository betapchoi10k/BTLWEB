using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class EWBillDao
    {
        QuanLyKyTucXaDb db = new QuanLyKyTucXaDb();
        public List<HDDienNuoc> getByMaSV(string MaSV = "")
        {
            return db.HDDienNuocs.Where(x => x.MaSV == MaSV).OrderBy(x => x.MaHDDN).ToList();
        }
        public HDDienNuoc viewDetails(string MaHD="")
        {
            return db.HDDienNuocs.SingleOrDefault(x => x.MaHDDN == MaHD);
        }
        public string InsertHD(HDDienNuoc entity)
        {
            try
            {
                db.HDDienNuocs.Add(entity);
                db.SaveChanges();

                return entity.MaHDDN;
            }
            catch
            {
                return null;
            }
        }
        public bool Delete(string MaHD)
        {
            try
            {
                var HDDN = db.HDDienNuocs.SingleOrDefault(x => x.MaHDDN == MaHD);
                db.HDDienNuocs.Remove(HDDN);
                db.SaveChanges();

               
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateHD(HDDienNuoc entity)
        {
            try
            {
                var hd = db.HDDienNuocs.SingleOrDefault(x => x.MaHDDN == entity.MaHDDN);
                hd.MaSV = entity.MaSV;
                hd.MaDien = entity.MaDien;
                hd.MaNuoc = entity.MaNuoc;
                hd.SoDien = entity.SoDien;
                hd.SoNuoc = entity.SoNuoc;
                hd.NgayLap = entity.NgayLap;
                hd.NgayTra = entity.NgayTra;

                //user.MaSV = entity.MaSV;
                db.SaveChanges();
               
            }
            catch
            {
                return false;
            }
            return true;
        }
        public IEnumerable<HDDienNuoc> showAllData(string searchString, int pageNumber = 1, int pageSize = 8)
        {
            IQueryable<HDDienNuoc> model = db.HDDienNuocs;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.MaHDDN.Contains(searchString)
                || x.MaSV.Contains(searchString));
            }
            return model.OrderBy(x => x.MaHDDN).ToPagedList(pageNumber, pageSize);

            //  return db.Accounts.OrderBy(x=>x.UserName).ToPagedList(pageNumber, pageSize);
        }
        public List<Dien> ListAllD()
        {
           return db.Diens.ToList();
        }
        public List<Nuoc> ListAllN()
        {
            return db.Nuocs.ToList();
        }
    }
}
