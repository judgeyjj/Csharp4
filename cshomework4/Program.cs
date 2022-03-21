using System;

namespace cshomework4
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService myOrder = new OrderService();
            myOrder.CreatOrder(20220320, "华中科技大学", "小华");
            myOrder.addOrder(20220320, "数据库原理", 20, 1);
            myOrder.addOrder(20220320, "计组", 100, 1);
            myOrder.addOrder(20220320, "C#程序设计", 30, 2);
            myOrder.CreatOrder(20220321, "武汉大学", "小武");
            myOrder.addOrder(20220321, "热水壶", 55, 1);
            myOrder.OutOrder();
            myOrder.FindOrder();
            myOrder.CreatOrder(20220000, "华中师范大学", "小师");
            myOrder.addOrder(20220000, "手机", 5000, 1);
            Console.WriteLine("排序前:");
            myOrder.OutOrder();
            myOrder.myList.Sort();
            Console.WriteLine("排序后:");
            myOrder.OutOrder();
            Console.ReadKey();
        }
    }
}
