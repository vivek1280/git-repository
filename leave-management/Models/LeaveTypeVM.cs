using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class DetailsLeaveTypeVM
    { 
        //go to middle of the key and ctrl+ . it will give you suggestion
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }
    }
    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}
