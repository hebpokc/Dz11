using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab14
{
    [DeveloperInfo2("Амир", "StroyDom")]
    class Building
    {
        private int buildingNum;
        private static int magnifier = 1;
        private double height;
        private int numOfFloors;
        private int numOfAparts;
        private int numOfEntrances;
        public Building(double height, int floors, int aparts, int entrances)
        {
            this.buildingNum = magnifier;
            this.height = height;
            this.numOfFloors = floors;
            this.numOfAparts = aparts;
            this.numOfEntrances = entrances;
            IncreaseNumber();
        }
        public Building()
        {
            this.buildingNum = magnifier;
            IncreaseNumber();
        }
        private void IncreaseNumber()
        {
            magnifier++;
        }
        public int BuildingNum
        {
            get
            {
                return buildingNum;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int NumOfFloors
        {
            get
            {
                return numOfFloors;
            }
            set
            {
                numOfFloors = value;
            }
        }
        public int NumOfAparts
        {
            get
            {
                return numOfAparts;
            }
            set
            {
                numOfAparts = value;
            }
        }
        public int NumOfEntrances
        {
            get
            {
                return numOfEntrances;
            }
            set
            {
                numOfEntrances = value;
            }
        }
        public double HeightOfFloor()
        {
            return Math.Round((height / (double)numOfFloors), 2);
        }
        public int NumOfApartInEntrances()
        {
            return numOfAparts / numOfEntrances;
        }
        public int NumOfApartOnFloor()
        {
            return NumOfApartInEntrances() / numOfFloors;
        }
        public override string ToString()
        {
            return $"\nНомер здания: {buildingNum}\nВысота: {height}\nКол-во этажей: {numOfFloors}\nКол-во квартир: {numOfAparts}" +
                $"\nКол-во подъездов: {numOfEntrances}";
        }
    }
}
