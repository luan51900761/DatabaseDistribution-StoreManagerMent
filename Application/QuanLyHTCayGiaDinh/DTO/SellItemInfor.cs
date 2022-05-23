using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DTO
{
    public class SellItemInfor
    {
        private int iD;
        private string productID;
        private string name;
        private int price;
        private int amount;
        private int money;
        private string sID;
        public SellItemInfor(string ProductID, string Name, int Amount, int Price, int Money, string SID)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Amount = Amount;
            this.Price = Price;
            this.Money = Money;
            this.SID = SID;
        }
        public string ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }
        public int Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }
        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string SID
        {
            get
            {
                return sID;
            }

            set
            {
                sID = value;
            }
        }
    }
}
