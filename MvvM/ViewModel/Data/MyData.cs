using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvM
{
    public class MyData:EntityBase
    {
        private string _Name;
        public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged("Name"); } }


        private string _Address;
        public string Address { get { return _Address; } set { _Address = value; OnPropertyChanged("Address"); } }


        private string _Age;
        public string Age { get { return _Age; } set { _Age = value; OnPropertyChanged("Age"); } }
    }
}
