using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HomeUnit> kermen = new List<HomeUnit>();
            string input = Console.ReadLine();
            int count = 0;
            while(input != "Democracy")
            {
                input = Console.ReadLine();
                try
                {
                    count++;
                    HomeUnit entity = HouseUnitFactory.CreateHouseUnitFactory(input);
                    kermen.Add(entity);
                }
                catch (Exception)
                {

                    
                }

                if (count % 3 == 0)
                {
                    foreach (var houseunit in kermen)
                    {
                        houseunit.GetIncome();
                    }
                }

                if (input == "EVN bill")
                {
                    foreach (var houseHold in kermen)
                    {
                        if (houseHold.CanPayBills())
                        {
                            houseHold.PayBills();
                        }
                    }
                }

                else if (input == "Evn")
                {
                    Console.WriteLine($"Total consumation: {kermen.Sum(x => x.Consumation)}");
                }
            }

            Console.WriteLine($"Total population: {kermen.Sum(x =>x.Population)}");
        }
    }
}
