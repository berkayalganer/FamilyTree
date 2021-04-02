using FamilyTree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Abstract
{
    public interface IPersonVerificationService
    {
        bool CheckPerson( long calculatedId, string firstName, string lastName, int birthYear );
    }
}
