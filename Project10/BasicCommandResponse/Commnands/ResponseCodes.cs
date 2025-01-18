using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCommandResponse.Commnands
{
    public abstract class ResponseCodes
    {
        public static string OperationCanceled = "OPERATION_CANCELED";
        public static string Success = "Success";
        public static string Error = "Error";
    }
}