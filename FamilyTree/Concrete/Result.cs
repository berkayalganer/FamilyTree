using FamilyTree.Abstract;
using FamilyTree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message, PersonForVerification data) : this(success)
        {
            Message = message;
            Data = data;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
        public PersonForVerification Data { get; }
    }
}
