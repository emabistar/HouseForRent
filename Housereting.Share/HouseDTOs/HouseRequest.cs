using System;
namespace Housereting.Share.HouseDTOs
{
	public class HouseRequest
	{
        public string? Name { get; set; }
        public string? Mode { get; set; }
        public string? Type { get; set; }
        public string? Price { get; set; }
        public string? Location { get; set; }
        public string? Size { get; set; }
        public int? NOfBed { get; set; }
        public int? NOfBath { get; set; }
        public string? Image { get; set; }
   
    }
}

