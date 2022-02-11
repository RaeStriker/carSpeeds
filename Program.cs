using System;

namespace carSpeeds
{
    public class Car
    {
        public Car(string make, string model, int speed)
        {
            Make = make;
            Model = model;
            Speed = speed;
        }

        public string Make { get; }
        public string Model { get; }
        public int Speed { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int carsToCheck = 3;
            int speedLimit = 0;

            string[] dialogue = {
                "Please enter the speed limit: ", // 0
                "Enter the make of the car: ", // 1
                "Enter the model of the car:", // 2
                "Enter the speed of the car: "}; // 3
            Car[] carArray = new Car[carsToCheck];


            speedLimit = getInt(getUI(dialogue[0]));

            for (int i = 1; i <= carsToCheck; i++)
            {
                carArray[i-1] = new Car(getUI(dialogue[1]), getUI(dialogue[2]), getInt(getUI(dialogue[3])));
            }

            for (int i = 1; i <= carsToCheck; i++)
            {
                
                Console.WriteLine(carArray[i-1].Make + " " + carArray[i - 1].Model + " " + carArray[i - 1].Speed + "mph " + getDemerit(carArray[i - 1].Speed, speedLimit) + " demerits");
                if (getDemerit(carArray[i - 1].Speed, speedLimit)>= 10)
                {
                    Console.WriteLine("<LICENSE SUSPENDED>");
                }

            }

                static string getUI(string question)
            {
                // getUserInput
                Console.Write(question);
                return Console.ReadLine();
            }
            
            static int getInt(string number)
            {
                return Int32.Parse(number);
            }

            static double getDemerit(int noombah, int limit)
            {
                double differentNoombah;
                if (noombah <= limit)
                    differentNoombah = 0;
                else
                    differentNoombah = ((noombah - limit)/5) + 1;
                return differentNoombah;
            }
        }
    }
}
