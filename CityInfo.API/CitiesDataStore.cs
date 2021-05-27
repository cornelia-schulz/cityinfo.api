using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Auckland",
                    Description = "The big smoke",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Skytower",
                            Description = "Big tower in the centre of town that you can have dinner at or jump off."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Mount Eden",
                            Description = "Volcano with awesome views over the whole of Auckland."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Sydney",
                    Description = "The one with the famous Opera House",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Opera House",
                            Description = "Opera House in the shape of a sail."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Darling Harbour",
                            Description = "Great area to stroll around and take in the sights."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with the big metal tower",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Eiffel Tower",
                            Description = "Big tower in the centre of the city."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Louvre",
                            Description = "Fantastic Museum full of art."
                        }
                    }
                }
            };
        }
    }
}
