using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot() { }

        public List<Car> Cars { get; set; } = new List<Car>();

        public void ListCarsInLot()
        {
            Console.WriteLine($"{Cars[0].Make} {Cars[0].Model} of the grand year {Cars[0].Year}");
            string[] phrases = new string[] { "or better yet, the", "also this beauty here, the", "but we must not forget the" };
            for (int i = 1; i < Cars.Count; i++)
            {
                Console.WriteLine(phrases[i % 3]);
                Console.WriteLine($"{Cars[i].Make} {Cars[i].Model} of the grand year {Cars[i].Year}");
            }
        }
    }
}
