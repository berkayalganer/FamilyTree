﻿using FamilyTree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Abstract
{
    public interface IPersonService
    {
        IResult VerifyPerson(PersonForVerification data);
    }
}