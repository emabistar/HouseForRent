using System;
namespace Housereting.Share.HouseDTOs
{
	public class HouseResponse<T>
	{
		public T?  Data {get;set;}
		public bool Success { get; set; }
		public string Message { get; set; } = string.Empty;
		 
	}
}

