using System;

namespace OOPadv
{
    public class TrafficLight
    {
        private TrafficLightEnum light;

        public TrafficLightEnum Light
        {
            get
            {
                return this.light;
            }
            private set
            {
                this.light = value;
            }
        }

        public TrafficLight(string light)
        {
            Enum.TryParse<TrafficLightEnum>(light, out this.light);
        }

        public void Update()
        {
            var currIndx = (int)this.light;
            currIndx++;
            currIndx %= Enum.GetValues(typeof(TrafficLightEnum)).Length;
            Enum.TryParse(currIndx.ToString(), out light);
        }



    }
}
