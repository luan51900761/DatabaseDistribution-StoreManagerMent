using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO
{
    public class StaffDAO1
    {
        private DBContextSV db;
        public StaffDAO1()
        {
            db = new DBContextSV(Program.connectionString);
        }

        public IEnumerable<nhanvien> ListAll()
        {
            //IQueryable để truy vấn dữ liệu. Vể bản chất IQuery to hơn IEnum

            IQueryable<nhanvien> model = db.nhanviens;
            return model.OrderBy(x => x.manv);
        }
        public string getIDbyUsername(string username)
        {
            return  db.taikhoans.Where(x => x.tentaikhoan == username).FirstOrDefault().nhanvien.manv;

        }
        public string getnewID()
        {
            string old = db.nhanviens.ToList().Last().manv;
            old = old.Replace("NV", "");
            return "NV" + (Int32.Parse(old) + 1).ToString();
        }

        public nhanvien getStaffLogedin()
        {
            string id = getIDbyUsername(Program.idLoged);
            return db.nhanviens.Where(x => x.manv == id).FirstOrDefault();

        }

        public int create(nhanvien nv)
        {
            //kiểm tra duplicate
            var result = db.nhanviens.Where(x => x.manv.Equals(nv.manv)).SingleOrDefault();
            if (result == null)
            {
                db.nhanviens.Add(nv);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Edit(nhanvien nv)
        {
            var result = db.nhanviens.Find(nv.manv);
            if (result != null)
            {
                //code update db

                result.manv = nv.manv;
                result.hoten = nv.hoten;
                result.sdt = nv.sdt;
                result.ngaylamviec = nv.ngaylamviec;
                result.macn = nv.macn;
                result.chucvu = nv.chucvu;
                result.ngaysinh = nv.ngaysinh;
                result.cnmd = nv.cnmd;
                result.gioitinh = nv.gioitinh;

                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int Delete(string manv)
        {
            var result = db.nhanviens.Find(manv);
            if (result == null)
            {
                return 0;
            }
            var tk = db.taikhoans.Find(manv);
            if (tk != null)
            {
                db.taikhoans.Remove(tk);
            }
            
            db.nhanviens.Remove(result);
            db.SaveChanges();
            return 1;
        }
    }
}
