using System.ComponentModel.DataAnnotations;

namespace Uppgift_Api_.Models.Entities
{
    public class OrderHandlerEntity
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int HandlerId { get; set; }

        public OrderEntity Order { get; set; }

        public HandlerEntity Handler { get; set; }
    }
}
