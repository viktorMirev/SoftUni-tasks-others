namespace OOPadv
{
    public class Room
    {
        private Pet myPet;
        

        public void AddPet(Pet newPet)
        {
            this.myPet = newPet;
        }

        public bool IsOccupied()
        {
            return this.myPet != null;
        }

        public void Release()
        {
            this.myPet = null;
        }

        public override string ToString()
        {
            if(this.myPet == null)
            {
                return "Room empty";
            }

            return this.myPet.ToString();
        }
    }
}
