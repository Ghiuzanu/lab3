using lab3.Models.Base;

namespace lab3.Models
{
    public class Student: BaseEntity
    {
        public string? Name { get; set; }  
        public int Age { get; set; }
    }
}
