using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ShopWithCar.data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Enter name, please")]
        [Required(ErrorMessage = "Name should be has more characters than 2")]
        [StringLength(20,MinimumLength = 2)] 
        
        public string name { get; set; }


        [Display(Name = "Enter Second name, please")]
        [Required(ErrorMessage = "Second name should be has more characters than 2")]
        [StringLength(20)]
        public string surName { get; set; }

        [Display(Name = "Enter your phone, please")]
        [Required(ErrorMessage = "Name should be has 10 characters")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        public string phone { get; set; }


        [Display(Name = "Enter your email, please")]
        [Required(ErrorMessage = "Email should be has email format")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        [ValidateNever]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
