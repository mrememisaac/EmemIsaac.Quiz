using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmemIsaac.QuizManager.Application.Common
{
    internal static class ValidationMessages
    {
        public static string RequiredMessage = "{PropertyName} is required";

        public static string MaximumLengthMessage(int maxLength) => "{PropertyName} must not exceed " + maxLength + " characters";
    }
}
