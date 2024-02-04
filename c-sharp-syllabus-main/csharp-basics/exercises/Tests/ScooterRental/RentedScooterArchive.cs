﻿using ScooterRental.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScooterRental
{
    public class RentedScooterArchive : IRentedScooterArchive
    {
        private readonly List<RentedScooter> _rentedScooterList;

        public RentedScooterArchive(List<RentedScooter> rentedScooterList)
        {
            _rentedScooterList = rentedScooterList;
        }

        public void AddRentedScooter(RentedScooter scooter)
        {
            _rentedScooterList.Add(scooter);
        }

        public RentedScooter EndRental(string scooterId, DateTime rentEnd)
        {
            var lastRentedScooter = _rentedScooterList
                                    .SingleOrDefault(scooter => scooter.ScooterId == scooterId && scooter.RentEnd == null);

            if (lastRentedScooter == null)
            {
                throw new ScooterNotFoundException("Scooter with provided id doesn't exist.");
            }

            if (rentEnd < lastRentedScooter.RentStart)
            {
                throw new InvalidDateException();
            }

            lastRentedScooter.RentEnd = rentEnd;

            return lastRentedScooter;
        }

        public List<RentedScooter> GetAllRentedScooterList()
        {
            return _rentedScooterList;
        }
    }
}
