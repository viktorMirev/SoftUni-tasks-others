namespace OOPadv
{
    public class Ferrari : ICar
    {
        public string model = "488-Spider";
        private string drName;

        public Ferrari(string drName)
        {
            this.DrName = drName;
        }

        public override string ToString()
        {
            return $"{this.model}/{this.Brakes()}/{this.PushPedal()}/{this.drName}";
        }

        public string DrName
        {
            get
            {
                return this.drName;
            }

            set
            {
                this.drName = value;
            }
        }
        public string Brakes()
        {
            return "Brakes!";
        }

        public string PushPedal()
        {
            return "Zadu6avam sA!";
        }
    }
}
