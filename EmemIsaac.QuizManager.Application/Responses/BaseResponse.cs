using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmemIsaac.QuizManager.Application.Responses
{
    public class BaseResponse
    {
        public bool Success { get; }

        public string Message { get; } = string.Empty;

        public IReadOnlyList<string>? ValidationErrors { get; }

        public BaseResponse(bool success = true, string message = "") { 
            Success = success; 
            Message = message;
        }

        public BaseResponse(IList<string> errors)
        {
            Success = false;
            ValidationErrors = new List<string>(errors);
        }
    }
}
