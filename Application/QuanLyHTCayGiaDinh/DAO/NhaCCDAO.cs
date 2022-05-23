using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    internal class NhaCCDAO
    {
        private DBContextSV db;
        public NhaCCDAO()
        {
            db = new DBContextSV(Program.connectionString);
        }

        public int create(nhacc ncc)
        {
            var result = db.nhaccs.Where(x => x.mancc.Equals(ncc.mancc)).SingleOrDefault();
            if (result == null)
            {
                db.nhaccs.Add(ncc);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Edit(nhacc ncc)
        {
            var result = db.nhaccs.Find(ncc.mancc);
            if (result != null)
            {
                result.mancc = ncc.mancc;
                result.diachi = ncc.diachi;
                result.email = ncc.email;
                result.tenncc = ncc.tenncc;

                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Delete(string mancc)
        {
            var result = db.nhaccs.Find(mancc);
            if (result == null)
            {
                return 0;
            }
            db.nhaccs.Remove(result);
            db.SaveChanges();
            return 1;
        }
    }
}
