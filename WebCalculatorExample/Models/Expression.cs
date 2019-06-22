using System.ComponentModel.DataAnnotations;

namespace WebCalculatorExample.Models
{
    public enum Operation
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
    public class Expression
    {
        [Key]
        public int Id { get; set; }
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public Operation Operation { get; set; }
        public int? ResultValue { get; set; }

        public Expression()
        { }

      

    }


}