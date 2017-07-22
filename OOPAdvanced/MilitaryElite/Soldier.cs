using System;


namespace OOPadv
{
    public abstract class Soldier : ISoldier
    {
        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }

        private string id;
        private string firstName;
        private string lastName;

        public Soldier(string id, string fname, string lname)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }
    }
}
