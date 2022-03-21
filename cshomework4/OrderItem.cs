namespace cshomework4
{
    public class OrderItem
    {
        private string name;    //商品名称
        private double price;    //商品单价
        private int number;     //需求量

        public int Number { get => number; set => number = value; }
        public double Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public OrderItem(string name, double price, int numb, Order order)
        {
            this.name = name;
            this.price = price;
            this.number = numb;
            TotalAcount(order);
        }
        public void TotalAcount(Order order)
        {
            order.TotalAmount += price * number;
        }
        public override bool Equals(object obj)
        {
            OrderItem m = obj as OrderItem;
            return m != null && m.name == name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();

        }

        public override string ToString()
        {
            return "\t商品：" + name + "\t单价：" + price + "\t需求量:" + number + "\n";
        }

    }
}
