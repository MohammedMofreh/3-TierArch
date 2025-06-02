using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public int NumberOfEmployees { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfModification { get; set; }   
        public bool IsModified { get; set; }
        public string? Status { get; set; }
        public string? ApprovalStatus { get; set; }
        public bool IsLocked { get; set; }
        public string? LockReason { get; set; }
        public string? LockedBy { get; set; }

    }
}
