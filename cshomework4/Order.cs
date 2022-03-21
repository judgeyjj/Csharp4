using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshomework4
{
    public class Order : IComparable
    {
        private int orderNum;    //订单号
        private DateTime date;   //订单时间
        private string adress;   //地址
        private string clent;    //客户
        private double totalAmount; //订单金额
        public List<OrderItem> orderItems = new List<OrderItem>();
        public int OrderNum { get => orderNum; set => orderNum = value; }
        public string Adress { get => adress; set => adress = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Clent { get => clent; set => clent = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }


        public Order(int orderNum, string adress, string clent)
        {
            date = DateTime.Now;
            this.orderNum = orderNum;
            this.adress = adress;
            this.clent = clent;
        }

        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.orderNum == orderNum;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();

        }

        public override string ToString()
        {
            String str;
            str = "订单号:" + orderNum + "\t地址:" + adress + "\t客户:" + clent + "\t创建时间:" + date + "\n订单明细：\n";
            for (int i = 0; i < orderItems.Count; i++)
                str += orderItems[i];
            str += "订单总金额：" + totalAmount;
            return str;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order))
                throw new NotImplementedException();
            Order rec = (Order)obj;
            return this.orderNum.CompareTo(rec.orderNum);
        }
    }
}
