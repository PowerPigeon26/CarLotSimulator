using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            
        }

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; } = "click clack click clack";
        public string HonkNoise { get; set; } = "Uh... line!?";
        public bool IsDriveable { get; set; } = false;

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine("Engine: " + engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine("Honk: " + honkNoise);
        }
    }
}
