using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepp
{
   public static class HomeUnitFactory
    {
        public static HomeUnit CreateHomeUnite(string input)
        {
            string[] info = Console.ReadLine().Split(new char[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string homeType = info[0];
            if(homeType == "YoungCouple")
            {
                decimal salaryOne = decimal.Parse(info[1]);
                decimal salaryTwo = decimal.Parse(info[2]);
                decimal tvCoast = decimal.Parse(info[3]);
                decimal fridgeCost = decimal.Parse(info[4]);
                decimal laptopCoast = decimal.Parse(info[5]);
                return new YoungCouple(salaryOne, salaryTwo, tvCoast, fridgeCost, laptopCoast);
            }
            else if( homeType == "YoungCoupleWithChildren")
            {
                decimal salaryOne = decimal.Parse(info[1]);
                decimal salaryTwo = decimal.Parse(info[2]);
                decimal tvCoast = decimal.Parse(info[3]);
                decimal fridgeCost = decimal.Parse(info[4]);
                decimal laptopCoast = decimal.Parse(info[5]);

                Child[] children = new Child[info.Length - 4];
                for (int i = 4; i < info.Length-4; i++)
                {
                    decimal[] consumption = info.split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries).S;
                    children[i - 4] = new Child[consumption];
                }

                return new YoungCoupleWithChildren(salaryOne, salaryTwo, tvCoast, fridgeCost, laptopCoast,children);
            }
            else if(homeType == "OldCouple")
            {
                decimal pensionOne = decimal.Parse(info[1]);
                decimal pensionTwo = decimal.Parse(info[2]);
                decimal tvCoast = decimal.Parse(info[3]);
                decimal fridgeCost = decimal.Parse(info[4]);
                decimal stoveCoast = decimal.Parse(info[5]);
                return new OldCouple(pensionOne, pensionTwo, tvCoast, fridgeCost, stoveCoast);
            }
            else if(homeType == "AloneYoung")
            {
                decimal salary = decimal.Parse(info[1]);
                decimal laptopCoast = decimal.Parse(info[2]);
                return new AloneYoung(salary, laptopCoast);
            }
            else if(homeType == "AloneOld")
            {
                decimal pension = decimal.Parse(info[1]);
                return new AloneOld(pension);
            }
        }
    }
}
