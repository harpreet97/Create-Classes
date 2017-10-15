using System;

namespace create_classes
{
    class Cars
    {
        private string _Make;
        private string _Model;
        private int _Year;

        public string Make
        {
            set
            {
                _Make = value;
            }
        }

        public string Model
        {
            set
            {
                _Model = value;
            }
        }

        public int Year
        {
            set
            {
                _Year = value;
            }
        }

        public Cars(string _make, string _model, int _year){
            Make = _make;
            Model = _model;
            Year = _year;

        }
        public string DisplayCar(){
            var showmycar = "The car we have created is:\n\n";
            showmycar += $"The make is {_Make}\n";
            showmycar += $"The model is {_Model}\n";
            showmycar += $"The year is {_Year}\n";

            return showmycar;

        }
            }
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Cars("Toyota", "Corola", 1986);
            var car2 = new Cars("Nissan", "Wingroad", 2002);
            var car3 = new Cars("Aston Martin", "DB11", 2017);

            Console.WriteLine(car1.DisplayCar());
            Console.WriteLine(car2.DisplayCar());
            Console.WriteLine(car3.DisplayCar());
        }
    }
}
