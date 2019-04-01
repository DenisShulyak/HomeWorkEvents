using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWRace
{
    class Program
    {
            delegate void GetToStart();
            delegate void StartRacing();
        static void Main(string[] args)
        {
            Game game = new Game();
            SportCar sportCar1 = new SportCar();
            SportCar sportCar2 = new SportCar();

            game.ReadyToStart(sportCar1, sportCar2);

            Console.ReadKey();

        }
    }
}
