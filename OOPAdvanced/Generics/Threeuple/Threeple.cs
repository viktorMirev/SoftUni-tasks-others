using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPadv
{
    public class Threeple<TOne,TTwo,TThree>
    {
        private TOne param1;
        private TTwo param2;
        private TThree param3;

        public override string ToString()
        {
            return $"{this.Param1} -> {this.Param2} -> {this.Param3}";
        }

        public Threeple(TOne p1, TTwo p2,TThree p3)
        {
            this.Param1 = p1;
            this.Param2 = p2;
            this.Param3 = p3;
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

        public TThree Param3
        {
            get
            {
                return this.param3;
            }
            private set
            {
                this.param3 = value;
            }
        }
    }
}
