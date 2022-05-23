using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    public class SupplierDAO
    {
        private DBContextSV db;
        public SupplierDAO()
        {
            db = new DBContextSV(Program.connectionString);
        }
        public IEnumerable<nhacc> ListAll()
        {
            //IQueryable để truy vấn dữ liệu. Vể bản chất IQuery to hơn IEnum

            IQueryable<nhacc> model = db.nhaccs;
            return model.OrderBy(x => x.mancc);
        }
    }
}
