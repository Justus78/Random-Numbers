using System.ComponentModel.DataAnnotations;

namespace Random_Numbers_Generator.Models
{
    public class RNG
    {       
        Random r = new Random();

        //[RegularExpression(@"^\d+$", ErrorMessage = "Please enter a valid positive integer.")]
        [Required(ErrorMessage = "Please enter a valid number.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid integer number.")]
        public int? Num1 { get; set; }

        [Required(ErrorMessage = "Please enter a valid number.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid integer number.")]
        //[RegularExpression("^[0-9]+$", ErrorMessage = "Please enter a valid positive integer.")]
        public int? Num2 { get; set;}

        [Required(ErrorMessage = "Please enter a valid number.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid integer number.")]
        //[RegularExpression("^[0-9]+$", ErrorMessage = "Please enter a valid positive integer.")]
        public int? Total { get; set;}
        public int? GetNumber() { 
            return r.Next((int)Math.Min((double)Num1, (double)Num2 + 1), (int)Math.Max((double)Num1, (double)Num2 + 1));
        } // end method
    } // end class
} // end namespace
