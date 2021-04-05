using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Abstract
{
    public abstract class CalculatingBaseClass
    {
        public abstract string Calculate(string nationalityId);
        public int CalculateThirdPart(int value, int lastPartOfNumber)
        {
            int number, total = 0, valueForReturn;
            while (value > 0)
            {
                number = value % 10;
                total += number;
                value /= 10;
            }
            if ((total % 10) <= lastPartOfNumber)
            {
                valueForReturn = lastPartOfNumber - (total % 10);
            }
            else
            {
                valueForReturn = ((((total / 10) + 1) * 10) + lastPartOfNumber) - total;
            }
            return valueForReturn;
        }
    }
}
