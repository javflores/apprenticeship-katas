namespace TheShoppingBasket.Domain.Basket
{
    public abstract class Product
    {
        private int _quantity;
        private readonly string _name;

        protected Product(string name)
        {
            _name = name;
        }

        protected Product(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public abstract Money Price { get; }

        public void IncreaseQuantity(Product product)
        {
            _quantity += product._quantity;
        }

        public Money Cost()
        {
            return Price * _quantity;
        }

        public bool MoreThan(int minimumQuantity)
        {
            return _quantity > minimumQuantity;
        }

        public int PacksOf(int packQuantity)
        {
            return _quantity / packQuantity;
        }

        public override bool Equals(object product)
        {
            return ((Product)product)._name == _name;
        }
    }
}