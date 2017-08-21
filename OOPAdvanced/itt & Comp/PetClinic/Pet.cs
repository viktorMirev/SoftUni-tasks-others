namespace OOPadv
{
    public class Pet
    {
        private string name;
        private int age;
        private string type;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }


        public Pet(string name, int age, string type)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{this.name} {this.age} {this.type}";
        }

    }
}

