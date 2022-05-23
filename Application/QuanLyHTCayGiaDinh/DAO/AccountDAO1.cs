using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    public class AccountDAO1
    {
        private DBContextSV db;
        public AccountDAO1()
        {
            db = new DBContextSV(Program.connectionString);
        }

        public IEnumerable<AccountAndStaff> listCustom()
        {
            IQueryable<AccountAndStaff> model = from n in db.nhanviens
                                             join t in db.taikhoans
                                             on n.manv equals t.manv
                                             select new AccountAndStaff()
                                             {
                                                 manv = t.manv,
                                                 hoten = n.hoten,
                                                 tentaikhoan = t.tentaikhoan,
                                                 matkhau = t.matkhau,
                                                 chucvu = n.chucvu,
                                                 macn = n.macn,
                                             };

            return model.OrderBy(x => x.manv);
        }

        public taikhoan getAccountLogedin()
        {
            return db.taikhoans.Where(x => x.tentaikhoan == Program.idLoged).FirstOrDefault();

        }

        public int create(taikhoan tk)
        {
            //kiểm tra duplicate
            var result = db.taikhoans.Where(x => x.tentaikhoan.Equals(tk.tentaikhoan)).SingleOrDefault();
            if (result == null)
            {
                db.taikhoans.Add(tk);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Edit(taikhoan tk)
        {
            var result = db.taikhoans.Find(tk.tentaikhoan);
            if (result != null)
            {
                //code update db

                result.manv = tk.manv;
                result.tentaikhoan = tk.tentaikhoan;
                result.matkhau = tk.matkhau;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Delete(string tentaikhoan)
        {
            var result = db.taikhoans.Find(tentaikhoan);
            if (result == null)
            {
                return 0;
            }
            db.taikhoans.Remove(result);
            db.SaveChanges();
            return 1;
        }
    }
}
