using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name {  get; set; }
        [Required(ErrorMessage = "Please enter your email address.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone/cell #.")]
        public string? Phone {  get; set; }
        [Required(ErrorMessage = "Specify whether you will attend the party.")]
        public bool? WillAttend { get; set; }   

    }
}
