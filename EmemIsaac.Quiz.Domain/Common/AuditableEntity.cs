using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmemIsaac.Quiz.Domain.Common
{
    public class AuditableEntity
    {
        public string? CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? DateLastModified { get; set; }

    }
}
