using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class AbstractHandler
    {
        private string _formate;

        public string Formate
        {
            get
            {
                return _formate;
            }
            set
            {
                _formate = value;
            }
        }

        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();
    }
}
