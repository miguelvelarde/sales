namespace Sales.Common.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection <City> Cities { get; set; }

        [DisplayName("Cities Count")]
        public int CitiesCount => Cities == null ? 0 : Cities.Count;
    }
}
