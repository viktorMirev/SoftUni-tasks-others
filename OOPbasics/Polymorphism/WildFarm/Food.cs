namespace WildFarm
{
    public abstract class Food
    {
        private int quantity;

        public Food(int q)
        {
            this.Quantity = q;
        }
        
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            private set
            {
                this.quantity = value;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + " " + this.quantity;
        }
    }

}
