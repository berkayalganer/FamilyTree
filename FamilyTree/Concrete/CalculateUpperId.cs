using FamilyTree.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Concrete
{
    public class CalculateUpperId : CalculatingBaseClass
    {
        public override string Calculate(string nationalityId)
        {
            int valueForSub = -4;

            int firstPart = Convert.ToInt32(nationalityId.Substring(0, 5)) + 3;
            int secondPart = Convert.ToInt32(nationalityId.Substring(5, 4)) - 1;
            //if (Convert.ToInt32(nationalityId.Substring(3, 2)) >= 97)
            //{
            //    valueForSub -= 2;
            //}
            //if (Convert.ToInt32(nationalityId.Substring(8, 1)) == 0)
            //{
            //    valueForSub += 2;
            //}
            int lastPart = CalculateLastPart(Convert.ToInt32(nationalityId.Substring(10, 1)), valueForSub);

            int thirdPart = CalculateThirdPart(Convert.ToInt32(firstPart.ToString() + secondPart.ToString()), lastPart);

            return firstPart.ToString() + secondPart.ToString() + thirdPart.ToString() + lastPart.ToString();
        }

        private int CalculateLastPart(int number, int valueForSub)
        {
            if (number < Math.Abs(valueForSub))
            {
                return number + 10 + valueForSub;
            }
            return number + valueForSub;
        }

    }
}
