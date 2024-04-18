using ClothingStore.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace ClothingStore.Products
{
    public class PromotionCategory : Entity<Guid>
    {
        public Guid CategoryId { get; set; }
        public Guid PromotionId { get; set; }

    }
}
