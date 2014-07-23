using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задача №1/////////////////////////////

            XMLHandler document = new XMLHandler();

            Console.WriteLine("That is {0} format",document.Formate);

            document.Create();
            document.Open();
            document.Chenge();
            document.Save();

            /////Задача №2////////////////////////////
            /*
            Player myPlayer = new Player();
            myPlayer.Play();
            myPlayer.Record();
            myPlayer.Pause();
            myPlayer.Stop();
            */
            ////////////////////////////////////////////
            Console.ReadLine();
        }
    }
}
