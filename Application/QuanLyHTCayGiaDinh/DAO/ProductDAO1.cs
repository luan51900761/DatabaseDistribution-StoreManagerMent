using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    public class ProductDAO1
    {
        private DBContextSV db;
        public ProductDAO1()
        {
            db = new DBContextSV(Program.connectionString);
        }
        public int create(sanpham sp)
        {
            //kiểm tra duplicate
            var result = db.sanphams.Where(x => x.masp.Equals(sp.masp)).SingleOrDefault();
            if (result == null)
            {
                db.sanphams.Add(sp);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Edit(sanpham sp)
        {
            var result = db.sanphams.Find(sp.masp);
            if (result != null)
            {
                //code update db
                
              result.masp = sp.masp;
              result.nhacc = sp.nhacc;
              result.nhasx = sp.nhasx;
               result.giaban = sp.giaban;
                result.loai = sp.loai;
                result.tensp = sp.tensp;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Delete(string masp)
        {
            var result = db.sanphams.Find(masp);
            if (result == null)
            {
                return 0;
            }
            db.sanphams.Remove(result);
            db.SaveChanges();
            return 1;
        }

    }
}
