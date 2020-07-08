using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JohnBryce
{
    public class ProductModel : IValidatableObject
    {
        public int id { get; set; }
        
        [Required(ErrorMessage = "Missing product name.")]
        [StringLength(40, ErrorMessage = "Product name can't exceeds 40 chars.")]
        [MinLength(2, ErrorMessage = "Product name mast be minimum 2 chars.")]
        [RegularExpression("^[A-Z].*$", ErrorMessage = "Product name must start with a capital letter.")]
        public string name { get; set; }

        [Required(ErrorMessage = "Missing unit price.")]
        [Range(0, 10000, ErrorMessage = "Price must be 0 to 10000.")]
        public decimal? price { get; set; }

        [Required(ErrorMessage = "Missing units in stock.")]
        public short? stock { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    List<ValidationResult> errors = new List<ValidationResult>();
        //    if (Char.IsDigit(name[0]))
        //    {
        //        errors.Add(new ValidationResult("First char can't be digit."));
        //    }
        //    if (price > 10 && price < 20)
        //    {
        //        errors.Add(new ValidationResult("Price can't be 10 to 20"));
        //    }
        //    return errors;
        //}

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Char.IsDigit(name[0]))
            {
                yield return new ValidationResult("First char can't be digit.");
            }
            if (price > 10 && price < 20)
            {
                yield return new ValidationResult("Price can't be 10 to 20");
            }
        }

    }
}
