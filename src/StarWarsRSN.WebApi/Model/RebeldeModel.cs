namespace StarWarsRSN.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public sealed class RebeldeDetailsModel
    {
        public int CustomerId { get; }

        public RebeldeDetailsModel(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
