using System;

namespace ReservationSystem.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) 
        {
        }
    }
}
