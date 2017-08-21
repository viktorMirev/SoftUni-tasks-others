using System;

namespace OOPadv
{
    public class MagicStone
    {
        private MagicStoneTypeWithStrenght strenght;
        private MagicStoneTypeWithAgility agility;
        private MagicStoneTypeWithVitality vitality;

        private Clarity clarity;

        public MagicStone(string type, string clarity)
        {
            Enum.TryParse<MagicStoneTypeWithStrenght>(type, out this.strenght);
            Enum.TryParse<MagicStoneTypeWithAgility>(type, out this.agility);
            Enum.TryParse<MagicStoneTypeWithVitality>(type, out this.vitality);

            Enum.TryParse<Clarity>(clarity, out this.clarity);
        }

        public int Strenght() { return (int)this.strenght + (int)this.clarity; }

        public int Agility() { return (int)this.agility + (int)this.clarity; }

        public int Vitality() { return (int)this.vitality + (int)this.clarity; }


    }
}
