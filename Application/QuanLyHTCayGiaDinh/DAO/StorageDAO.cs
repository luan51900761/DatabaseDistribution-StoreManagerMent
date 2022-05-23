using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    public class StorageDAO
    {
        private DBContextSV db;
        public StorageDAO()
        {
            db = new DBContextSV(Program.connectionString);
        }
        public int create(kho k)
        {
            var result = db.khoes.Where(x => x.makho.Equals(k.makho)).SingleOrDefault();
            if (result == null)
            {
                db.khoes.Add(k);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public IEnumerable<SellGridView> listCustom()
        {
            IQueryable<SellGridView> model = from t in db.tonkhoes
                                             join s in db.sanphams
                                             on t.masp equals s.masp
                                             select new SellGridView()
                                             {
                                                 makho = t.makho,
                                                 masp = t.masp,
                                                 tensp = s.tensp,
                                                 nhasx = s.nhasx,
                                                 loai = s.loai,
                                                 giaban = s.giaban,
                                                 soluong = t.soluong
                                           };

            return model.OrderBy(x => x.masp);
        }
        public IEnumerable<SellGridView> listCustombyCN(string key)
        {
            IQueryable<SellGridView> model = from t in db.tonkhoes
                                             join s in db.sanphams
                                             on t.masp equals s.masp
                                             where t.kho.macn == key
                                             select new SellGridView()
                                             {
                                                 makho = t.makho,
                                                 masp = t.masp,
                                                 tensp = s.tensp,
                                                 nhasx = s.nhasx,
                                                 loai = s.loai,
                                                 giaban = s.giaban,
                                                 soluong = t.soluong
                                             };

            return model.OrderBy(x => x.masp);
        }
        public IEnumerable<SellGridView> listCustombyID(string key)
        {
            IQueryable<SellGridView> model = from t in db.tonkhoes
                                             join s in db.sanphams
                                             on t.masp equals s.masp
                                             where s.masp.Contains(key)
                                             select new SellGridView()
                                             {
                                                 makho = t.makho,
                                                 masp = t.masp,
                                                 tensp = s.tensp,
                                                 nhasx = s.nhasx,
                                                 loai = s.loai,
                                                 giaban = s.giaban,
                                                 soluong = t.soluong
                                             };

            return model.OrderBy(x => x.masp);
        }
        public IEnumerable<SellGridView> listCustombyType(string key)
        {
            IQueryable<SellGridView> model = from t in db.tonkhoes
                                             join s in db.sanphams
                                             on t.masp equals s.masp
                                             where s.loai.Contains(key)
                                             select new SellGridView()
                                             {
                                                 makho = t.makho,
                                                 masp = t.masp,
                                                 tensp = s.tensp,
                                                 nhasx = s.nhasx,
                                                 loai = s.loai,
                                                 giaban = s.giaban,
                                                 soluong = t.soluong
                                             };

            return model.OrderBy(x => x.masp);
        }
        public string getnewid()
        {
            string old = db.khoes.ToList().Last().makho;
            old = old.Replace("K", "");
            return "K" + (Int32.Parse(old) + 1).ToString();
        }

        public IEnumerable<SellGridView> listCustombyName(string key)
        {
            IQueryable<SellGridView> model = from t in db.tonkhoes
                                             join s in db.sanphams
                                             on t.masp equals s.masp
                                             where s.tensp.Contains(key)
                                             select new SellGridView()
                                             {
                                                 makho = t.makho,
                                                 masp = t.masp,
                                                 tensp = s.tensp,
                                                 nhasx = s.nhasx,
                                                 loai = s.loai,
                                                 giaban = s.giaban,
                                                 soluong = t.soluong
                                             };

            return model.OrderBy(x => x.masp);
        }
    }
}
