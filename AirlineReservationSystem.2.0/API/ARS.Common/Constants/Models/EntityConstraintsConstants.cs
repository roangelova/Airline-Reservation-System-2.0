﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.Constants.models
{
    public static class EntityConstraintsConstants
    {
        public const int AircraftModelMaxLength = 50;
        public const int AircraftImageUrlMaxLength = 2000;

        public const int AirlineMaxNameLength = 50;
        public const int AirlineMaxDescriptionLength = 500;
        public const int AirlineMaxLogoImageLength = 2000;

        public const int CrewMemberMaxNameLength = 80;
        public const int CrewMemberMaxAvatarUrl = 2000;

        public const int IATA_AirlineCodeMaxLength = 2;
        public const int IATA_AirportCodeMaxLength = 3;
        public const int DestinationNameMaxLength = 50;

        public const int PassengerMaxNameLength = 60;
        public const int PassengerMaxNationalityLength = 50;
        public const int PassengerMaxDocumentNumberLength = 30;

        public const int UserNameMaxLength = 50;

        public const int CityMaxLength = 30;
        public const int PostalCodeMaxLength = 30;
        public const int StreetMaxLength = 30;
        public const int RegionMaxLength = 30;
        public const int DetailsMaxLength = 30;
    }
}
