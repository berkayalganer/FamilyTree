using FamilyTree.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Entities
{
    public class PersonForVerification : IEntity
    {
        public string NationalityId { get; set; }
        public string TargetFirstName { get; set; }
        public string TargetLastName { get; set; }
        public int TargetBirthYear { get; set; }
        public string TargetNationalityId { get; set; }
    }
}
