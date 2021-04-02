using FamilyTree.Abstract;
using FamilyTree.Entities;
using FamilyTree.NationalityId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Adapters
{
    public class NationalityIdServiceAdapter : IPersonVerificationService
    {
        public bool CheckPerson( long calculatedId, string firstName, string lastName, int birthYear )
        {
            using (KPSPublicSoapClient client = new KPSPublicSoapClient())
            {
                return client.TCKimlikNoDogrula(calculatedId, firstName, lastName, birthYear);
            }
        }
    }
}
