using System;
using HouseRenting.Share.Entities;
using Housereting.Share.HouseDTOs;

namespace HouseReting.Client.Services
{
	public interface IServiceClient
	{
        Task<HouseResponse<List<House>>> GetAllHouseAsync();

        Task<HouseResponse<House>> CreateHouseAsync(HouseRequest house);

        Task<HouseResponse<House>> GetHouseByIdAsync(int id);

        Task<HouseResponse<House>> UpdateHouseAsync(int id, HouseRequest houseRequest);

        Task<HouseResponse<bool>> DeleteHouseAsync(int Id);
    }
}

