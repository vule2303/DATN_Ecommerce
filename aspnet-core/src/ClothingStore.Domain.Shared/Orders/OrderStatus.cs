using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
