using FamilyTree.Abstract;
using FamilyTree.Adapters;
using FamilyTree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonVerificationService _verificationService;
        private CalculatingBaseClass _calculateBaseClass;
        public PersonManager(IPersonVerificationService verificationService, CalculatingBaseClass calculatingBaseClass)
        {
            _verificationService = verificationService;
            _calculateBaseClass = calculatingBaseClass;
        }
        public IResult VerifyPerson(PersonForVerification data)
        {
            int triggerForStop = 0;
            data.TargetNationalityId = _calculateBaseClass.Calculate(data.NationalityId);
            while (!_verificationService.CheckPerson(long.Parse(data.TargetNationalityId), data.TargetFirstName, data.TargetLastName, data.TargetBirthYear))
            {
                triggerForStop++;
                data.TargetNationalityId = _calculateBaseClass.Calculate(data.TargetNationalityId);
                if (triggerForStop == 100)
                    return new Result(false);
            }          
            return new Result(true, "Başarılı", data);
        }

    }
}
