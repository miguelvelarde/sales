namespace Sales.Common.Entities
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }

        [DisplayName("Departments Count")]
        public int DepartmentsCount => Departments == null ? 0 : Departments.Count;

    }
}
