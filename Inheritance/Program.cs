using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Bird objectOfBird = new Bird();
            objectOfBird.haveFeathers = true;
            objectOfBird.haveWings = true;
            objectOfBird.haveWings = true;
            objectOfBird.canFly = true;

        
            Reptile objectOfReptile = new Reptile();
            objectOfReptile.eyesColor = "yellow";
            objectOfReptile.lookCute = true;
            objectOfReptile.dangerous = true;


            var myAnimals = new Bird[] { objectOfBird };
            foreach(var animal in myAnimals)
            {
                Console.WriteLine("Bird have eggs =" + animal.haveEggs); // is this false because i didn't assignied any value 
                Console.WriteLine("Bird have feather =" + animal.haveFeathers);
                Console.WriteLine("Bird have wings =" + animal.haveWings);

            }









        }
    }
}
