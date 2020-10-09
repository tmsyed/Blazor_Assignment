using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContactProject.Data
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Last Name cannot exceed 250 characters")]
        public string LastName { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Last Name cannot exceed 250 characters")]
        public string FirstName { get; set; }
        [StringLength(15, ErrorMessage = "Last Name cannot exceed 15 characters")]
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}