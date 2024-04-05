using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "The Full Name field is required.")]
        public string NameAndSurname { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Desired Consultation Date field is required.")]
        [FutureDate(ErrorMessage = "Consultation date must be in the future.")]
        [NotOnWeekend(ErrorMessage = "Consultation cannot be scheduled on a weekend.")]
        [NotOnSpecificDay(DayOfWeek.Monday)]
        public DateTime ConsultationDate { get; set; }

        [Required(ErrorMessage = "The Product field is required.")]
        public string Product { get; set; }
    }
}
