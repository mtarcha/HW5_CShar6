using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player: IPlayable,IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Player is plaing now");
        }

        public void Pause()
        {
            Console.WriteLine("Player is on the pause");
        }

        public void Stop()
        {
            Console.WriteLine("Player stops it's work");
        }

        public void Record()
        {
            Console.WriteLine("Player is recording now");
        }
    }
}
