using System;
namespace Domain.Enums
{
    public enum PaymentStatus
    {
        Pending,
        Authorized,
        Captured,
        Failed,
        Refunded,
        PartiallyRefunded,
        Cancelled
    }
}

