using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
   public abstract class Animal : Sounder
    {

        private string name;
        private int age;
        private string gender;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.Append($"{this.name} {this.age} {this.gender}");
            return sb.ToString();

        }

       
        

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            protected  set
            {
                
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid input!");
                this.name = value;
            }

        }
        
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value<0) throw new ArgumentException("Invalid input!");
                this.age = value;
            }
        }

        public virtual string Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {

                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid input!");
                this.gender = value;
            }

        }

    }
}
