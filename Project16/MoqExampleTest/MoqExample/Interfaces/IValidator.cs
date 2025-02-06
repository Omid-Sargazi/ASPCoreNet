using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqExample.Interfaces
{
    public interface IValidator
    {
        bool Validator(ref string input);
    }
}