using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab13
{
    class BuildingCollection
    {
        Building[] buildings = new Building[10];
        public Building[] Buildings
        {
            get
            {
                return buildings;
            }
        }
        public Building this[int index]
        {
            get
            {
                if (index >= 0 && index < buildings.Length)
                    return buildings[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public void Add(Building a)
        {
            if (a.BuildingNum <= 10)
            {
                buildings[a.BuildingNum - 1] = a;
            }
            else
            {
                Console.WriteLine("\nМассив расчитан на 10 зданий");
            }
        }
    }
}
