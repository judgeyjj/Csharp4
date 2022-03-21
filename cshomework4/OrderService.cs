using System;
using System.Collections.Generic;
using System.Linq;


namespace cshomework4
{
    public class OrderService
    {
        public List<Order> myList = new List<Order>();
        public void CreatOrder(int orderNum, string adress, string clent)  //创建订单
        {
            Order order = new Order(orderNum, adress, clent);
            myList.Add(order);
        }
        public void addOrder(int orderNum, string name, double price, int numb)  //在订单n中创建明细
        {
            int i;
            for (i = 0; i < myList.Count; i++)
                if (myList[i].OrderNum == orderNum)
                    break;
            OrderItem orderItem = new OrderItem(name, price, numb, myList[i]);
            myList[i].orderItems.Add(orderItem);
        }
        public void DelOrder(int orderNum)      //删除订单
        {
            int i;
            for (i = 0; i < myList.Count; i++)
                if (myList[i].OrderNum == orderNum)
                    break;
            myList.Remove(myList[i]);
        }

        public void RenewOrder(int n, int m, int price)       //修改订单明细的价格
        {
            myList[n - 1].orderItems[m - 1].Price = price;
        }
        public void OutOrder()      //输出订单
        {
            for (int i = 0; i < myList.Count(); i++)
                System.Console.WriteLine((i + 1) + "  " + myList[i]);
        }
        public void FindOrder()     //查询订单
        {
            var lowPrice = from n in myList
                           where n.TotalAmount < 100
                           orderby n.TotalAmount
                           select n;
            Console.WriteLine("订单总价低于100元的有：");
            foreach (var n in lowPrice)
            {
                Console.WriteLine(n);
            }
        }
    }
}
