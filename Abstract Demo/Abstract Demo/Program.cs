using System;

namespace Abstract_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman cs  = new CarSalesman("Mayank" , "Dama");
            cs.Sell();

            RetailerSalesman rs = new RetailerSalesman("Mayank", "Dama");
            rs.Sell();
        }
    }
}
