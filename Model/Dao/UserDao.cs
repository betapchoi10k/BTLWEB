using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;
namespace Model.Dao
{
  public  class UserDao
    {
        QuanLyKyTucXaDb db = null;
        public UserDao()
        {
            db = new QuanLyKyTucXaDb();

        }
        public Account GetByUserName(string userN)
        {
            return db.Accounts.SingleOrDefault(x => x.UserName == userN);
        }
        public Account ViewDetail (string Masv)
        {
            return db.Accounts.SingleOrDefault(x => x.MaSV == Masv);
           // db.Accounts.Find(Masv);

        }

        public string Insert(Account entity)
        {
            // thêm try 
            try
            {
                db.Accounts.Add(entity);
                db.SaveChanges();
                return entity.MaSV;
            }
            catch
            {
                return null;
            }
            
        }
        public bool Update(Account entity)
        {
            try {
                var user = db.Accounts.SingleOrDefault(x=>x.MaSV==entity.MaSV);
                user.Password = entity.Password;
                user.EmailAddress = entity.EmailAddress;
                //user.MaSV = entity.MaSV;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
          
        }
        public bool Delete(string MaSV)
        {
            try {
                var user = db.Accounts.SingleOrDefault(x => x.MaSV == MaSV);
                db.Accounts.Remove(user);
                db.SaveChanges();
                
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;

        }
        public IEnumerable<Account> showAllData(string searchString, int pageNumber = 1, int pageSize = 8)
        {
            IQueryable<Account> model= db.Accounts;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.UserName.Contains(searchString)
                || x.EmailAddress.Contains(searchString));
            }
            return model.OrderBy(x => x.UserName).ToPagedList(pageNumber, pageSize);

          //  return db.Accounts.OrderBy(x=>x.UserName).ToPagedList(pageNumber, pageSize);
        }
        public bool Login(string userName , string passWord)
        {
            var res = db.Accounts.Count(x => x.UserName == userName && x.Password == passWord);// kiểm tra 
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //var res = db.Accounts.SingleOrDefault(x => x.UserName == userName);
            //if (res ==  null)
            //{
            //    return 0;
            //}
            //if( res.Status==false)
            //{
            //    return -1;
            //}
            //else
            //{
            //    if(res.Password==passWord)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return -2;
            //    }

            //}

        }
    }
}
