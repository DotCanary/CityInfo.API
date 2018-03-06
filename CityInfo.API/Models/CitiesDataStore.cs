using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with a big park",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited park"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102 storey skzscraper"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral",
                            Description = "Gothic"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 4,
                            Name = "Central Station",
                            Description = "Railway"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with a big tower",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "The most visited park"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "Museum"
                        }
                    }
                },
            };
        }
    }
}
