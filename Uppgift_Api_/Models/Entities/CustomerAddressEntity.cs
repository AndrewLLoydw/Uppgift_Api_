using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uppgift_Api_.Models.Entities
{
    public class CustomerAddressEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string StreetName { get; set; }

        [Required]
        [Column(TypeName = "char(5)")]
        public int PostalCode { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Updated { get; set; }

        public virtual ICollection<CustomerEntity> Customers { get; set; }
    }
}
