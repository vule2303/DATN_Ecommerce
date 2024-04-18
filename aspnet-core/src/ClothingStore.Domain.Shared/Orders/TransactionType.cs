using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
