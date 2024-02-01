using System;
using HouseRenting.Share.Entities;

namespace HouseRenting.Server.Repositories
{
	public interface IHouseRepository
	{
        Task<List<House>> GetAllHouseAsync();
        Task<House> GetHouseByIdAsync(int Id);
        Task<House> CreateHouseAsync(House house);
        Task<House> UpdateHouseAsync(House house);
        Task<bool> DeleteHouseAsync(int id);

    }
}

