using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot myLot = new CarLot();

            Car car1 = new Car();
            car1.Make = "Acura";
            car1.Model = "Civic";
            car1.Year = 2005;
            car1.EngineNoise = "Whirrrrr";
            car1.HonkNoise = "BLAAATT";
            car1.IsDriveable = false;   //cause this car has been such a lemon >:(
            myLot.Cars.Add(car1);
            Car car2 = new Car()
            {
                Make = "Starship",
                Model = "Enterprise",
                Year = 2025,
                EngineNoise = "Low hum",
                HonkNoise = "Phasers firing",
                IsDriveable = true //Oh it does more than "drive" lol
            };
            myLot.Cars.Add(car2);
            Car car3 = new Car("Chrysler", "Concorde", 1998, "Reeeenenenener", "HOWDY!", true); //ol reliable :)
            myLot.Cars.Add(car3);

            Console.WriteLine($"This is the {car1.Model} {car1.Make}. Behold its mighty sounds!");
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine("");
            Console.WriteLine($"This is the {car2.Model} {car2.Make}. Behold its mighty sounds!");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine("");
            Console.WriteLine($"This is the {car3.Model} {car3.Make}. Behold its mighty sounds!");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            Console.WriteLine("\n"); 
            Console.WriteLine("These are the mighty cars that fill my humble lot. Feast your eyes on the...");
            myLot.ListCarsInLot();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // CHECKED

            //*************BONUS X 2*************//

            //Create a CarLot class
            //CHECKED
            //It should have at least one property: a List of cars
            //CHECKED
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //CHECKED
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console 
            //CHECK?
        }
    }
}
