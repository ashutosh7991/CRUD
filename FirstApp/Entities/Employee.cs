using System.ComponentModel.DataAnnotations;

namespace FirstApp.Entities
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public int? Phone { get; set; }

        public int? Salary { get; set; }
    }
}
