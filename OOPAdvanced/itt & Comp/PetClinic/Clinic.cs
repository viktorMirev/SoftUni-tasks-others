using System;
using System.Collections.Generic;

namespace OOPadv
{
    public class Clinic
    {
        private List<Room> rooms;
        private string name;

        private int numberOfRooms;

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

        

        public int NumberOfRooms
        {
            get
            {
                return this.numberOfRooms;
            }
            private set
            {
                if (value % 2 == 0) throw new Exception("Invalid Operation!");
                this.numberOfRooms = value;
            }
        }

        public Clinic(string name, int n)
        {
            this.NumberOfRooms = n;
            this.Name = name;
            this.rooms = new List<Room>();
            for (int i = 0; i < n; i++)
            {
                this.rooms.Add(new Room());
            }
        }

        public bool HasEmptyRooms()
        {
            bool res = false;
            foreach (var item in rooms)
            {
                if (!item.IsOccupied()) res = true;
            }
            return res;
        }

        public void Print()
        {
            foreach (var room in rooms)
            {
                Console.WriteLine(room);
            }
        }

        public void Print(int n)
        {
            Console.WriteLine(rooms[n - 1]);
        }

        public bool Add(Pet newPet)
        {
            if(this.HasEmptyRooms() == true)
            {
                
                var centerIndex = this.numberOfRooms / 2;
                var currIndex = centerIndex;



                for (int i = 0; i < this.rooms.Count; i++)
                {
                    if (!rooms[currIndex].IsOccupied())
                    {
                        rooms[currIndex].AddPet(newPet);
                        break;
                    }

                    if (currIndex >= centerIndex)
                    {
                        currIndex -= (i + 1);
                    }
                    else
                    {
                        currIndex += (i + 1);
                    }

                    

                }

                return true;
                
            }
            return false;
        }

        public bool Release()
        {
            for (int i = numberOfRooms/2 ; i < this.numberOfRooms; i++)
            {
                if (rooms[i].IsOccupied())
                {
                    rooms[i].Release();
                    return true;
                }
            }

            for (int i = 0; i < numberOfRooms/2; i++)
            {
                if (rooms[i].IsOccupied())
                {
                    rooms[i].Release();
                    return true;
                }
            }


            return false;
        }
    }
}
