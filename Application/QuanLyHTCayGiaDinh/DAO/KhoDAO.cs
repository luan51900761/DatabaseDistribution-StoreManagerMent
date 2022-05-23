using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHoa.DTO;


namespace QuanLyBanHoa.DAO
{
    internal class KhoDAO
    {
        private DBContextSV db;
        public KhoDAO()
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
        public int Edit(kho k)
        {
            var result = db.khoes.Find(k.makho);
            if (result != null)
            {
                result.makho = k.makho;
                result.diachi = k.diachi;
                result.macn = k.macn;
                result.chinhanh = k.chinhanh;

                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Delete(string makho)
        {
            var result = db.khoes.Find(makho);
            if (result == null)
            {
                return 0;
            }
            db.khoes.Remove(result);
            db.SaveChanges();
            return 1;
        }
    }
}
