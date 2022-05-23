using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DTO
{
    public class Dataprovider
    {
        

        private static Dataprovider instance;
        public static Dataprovider Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dataprovider();
                return instance;
            }
            private set { instance = value; }
        }
        private Dataprovider() { }
        public string connectHost = "data source=DESKTOP-BELSK30\\HOST;initial catalog = quanlycuahang; user id = sa; password=123456;MultipleActiveResultSets=True;App=EntityFramework";
        public string connectStore1 = "data source=DESKTOP-BELSK30\\STORE1;initial catalog = quanlycuahang; user id = sa; password=123456;MultipleActiveResultSets=True;App=EntityFramework";
        public string connectStore2 = "data source=DESKTOP-BELSK30\\STORE2;initial catalog = quanlycuahang; user id = sa; password=123456;MultipleActiveResultSets=True;App=EntityFramework";
    }

}
