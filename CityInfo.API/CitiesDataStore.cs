﻿using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name = "Central Park",
                            Description = "The most visited urban park in US.Yuhuu"
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Satu Mare",
                    Description = "Home Town :)"
                }
            };
        }
    }
}
