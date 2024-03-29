﻿using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neigborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neigborhood = neigborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract<Notification>()
                        .Requires()
                        .IsNullOrEmpty(Street, "Address.Street", "Street inválido")
                        .IsNullOrEmpty(Number, "Address.Number", "Number inválido"));
        }

        public string Street { get; private set; } = string.Empty;
        public string Number { get; private set; } = string.Empty;
        public string Neigborhood { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public string State { get; private set; } = string.Empty;
        public string Country { get; private set; } = string.Empty;
        public string ZipCode { get; private set; } = string.Empty;
    }
}
