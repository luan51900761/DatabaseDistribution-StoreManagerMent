using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    public class ImportDAO
    {
        private DBContextSV db;
        public ImportDAO()
        {
            db = new DBContextSV(Program.connectionString);
        }
        public string getnewID()
        {
            string old = db.phieunhaps.ToList().Last().mapn;
            old = old.Replace("PN", "");
            return "PN" + (Int32.Parse(old) + 1).ToString();
        }

        public int create(phieunhap pn)
        {
            //kiểm tra duplicate
            var result = db.phieunhaps.Where(x => x.mapn.Equals(pn.mapn)).SingleOrDefault();
            if (result == null)
            {
                db.phieunhaps.Add(pn);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Edit(phieunhap pn)
        {
            var result = db.phieunhaps.Find(pn.mapn);
            if (result != null)
            {
                //code update db

                result.mapn = pn.mapn;
                result.tinhtrang = pn.tinhtrang;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Delete(string mapn)
        {
            var result = db.phieunhaps.Find(mapn);
            if (result == null)
            {
                return 0;
            }
            var tk = db.chitietphieunhaps.Find(mapn);
            if (tk != null)
            {
                db.chitietphieunhaps.Remove(tk);
            }

            db.phieunhaps.Remove(result);
            db.SaveChanges();
            return 1;
        }

        public  int createDetailImport(chitietphieunhap ctpn)
        {
                db.chitietphieunhaps.Add(ctpn);
                db.SaveChanges();
                return 1;
        }
    }
}
