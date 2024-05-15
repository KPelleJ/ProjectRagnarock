using System.ComponentModel.DataAnnotations;

namespace ProjectRagnarock.Models
{
    public class Customer:User
    {
        [Required]
        [StringLength(4)]
        [DataType(DataType.Password)]
        [Display(Name = "Pincode")]
        public string PinCode { get; set; }
    }
}
