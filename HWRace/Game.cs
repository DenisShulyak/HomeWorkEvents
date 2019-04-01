using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HWRace
{
   

    public class Game
    {
        int mile = 100;
        private Car winner;

        public void ReadyToStart(SportCar sp, SportCar sp2)
        {
            winner = (Car)null;
            sp.Driving += CarDriving;
            sp2.Driving += CarDriving;
            sp.Finish += CarFinish;
            sp2.Finish += CarFinish;
            sp.GetReady();
            sp2.GetReady();
            Console.Clear();
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Поехали!");
            Thread.Sleep(800);
            Console.Clear();

            for (float t = 0; ; t += 0.1F)
            {
                Console.SetCursorPosition(0, 0); 
                
                sp.Drive(t, 400);
                sp2.Drive(t, 400);
                Thread.Sleep(100);
                if (winner != null)
                    break;
            }
            Console.WriteLine("Победил: " + winner.Name);
        }

        private void CarFinish(Car car)
        {
            winner = car;
        }

        private void CarDriving(Car car, float distance)
        {
            Console.WriteLine("Автомобиль: " + car.Name + " Расстояние: " + distance);
        }
        

    }
}