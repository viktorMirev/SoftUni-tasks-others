using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Tuple<TOne,TTwo>
    {
        private TOne param1;
        private TTwo param2;

        public override string ToString()
        {
            return $"{this.Param1} -> {this.Param2}";
        }

        public Tuple(TOne p1, TTwo p2)
        {
            this.Param1 = p1;
            this.Param2 = p2;
        }

        public TOne Param1
        {
            get
            {
                return this.param1;
            }
            private set
            {
                this.param1 = value;
            }
        }

        public TTwo Param2
        {
            get
            {
                return this.param2;
            }
            private set
            {
                this.param2 = value;
            }
        }
    }
}
