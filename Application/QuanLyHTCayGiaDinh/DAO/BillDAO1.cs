using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    public class BillDAO1
    {
        private DBContextSV db;
        public BillDAO1()
        {
            db = new DBContextSV(Program.connectionString);
        }

        public int create(hoadon h)
        {
            var result = db.hoadons.Where(x => x.mahd.Equals(h.mahd)).SingleOrDefault();
            if (result == null)
            {
                db.hoadons.Add(h);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int createDetailbill(chitiethoadon h)
        {
                db.chitiethoadons.Add(h);
                db.SaveChanges();
                return 1;

        }
        public string getnewID()
        {
            string old = db.hoadons.ToList().Last().mahd;
            old = old.Replace("HD", "");
            return "HD" + (Int32.Parse(old) + 1).ToString();
        }
    }
}
