using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DOCHandler: AbstractHandler
    {
        private readonly string _formate = "DOC";

        public string Formate
        {
            get
            {
                return _formate;
            }
        }

        public override void Open()
        {
            Console.WriteLine("The DOC document is opened");
        }
        public override void Create()
        {
            Console.WriteLine("The DOC document is created");
        }
        public override void Chenge()
        {
            Console.WriteLine("The DOC document is changed");
        }
        public override void Save()
        {
            Console.WriteLine("The DOC document is saved");
        }
    }
}
