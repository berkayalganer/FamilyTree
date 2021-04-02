using FamilyTree.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Concrete
{
    public class CalculateLowerId : CalculatingBaseClass
    {
        public override string Calculate(string nationalityId)
        {
            int valueForSum = 4;

            int firstPart = Convert.ToInt32(nationalityId.Substring(0, 5)) - 3;
            int secondPart = Convert.ToInt32(nationalityId.Substring(5, 4)) + 1;
            if (Convert.ToInt32(nationalityId.Substring(2, 3)) <= 102)
            {
                valueForSum += 2;
            }
            if (Convert.ToInt32(nationalityId.Substring(8, 1)) == 9)
            {
                valueForSum -= 2;
            }
            int lastPart = Convert.ToInt32(nationalityId.Substring(10, 1)) + valueForSum;
            if (lastPart >= 10)
                lastPart = (lastPart + valueForSum) % 10;

            int thirdPart = CalculateThirdPart(Convert.ToInt32(firstPart.ToString() + secondPart.ToString()), lastPart);

            return firstPart.ToString() + secondPart.ToString() + thirdPart.ToString() + lastPart.ToString();
        }
    }
}
