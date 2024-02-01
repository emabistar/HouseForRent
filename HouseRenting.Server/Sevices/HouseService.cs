using System;
using Azure;
using HouseRenting.Server.Repositories;
using HouseRenting.Share.Entities;
using Housereting.Share.HouseDTOs;

namespace HouseRenting.Server.Sevices
{
	public class HouseService: IHouseService
    {
        private readonly IHouseRepository _repos;
        public HouseService(IHouseRepository repos)
		{
            
               _repos = repos;
		}

        public  async Task<HouseResponse<House>> CreateHouseAsync(HouseRequest houserequest)
        {
                var response = new HouseResponse<House>();
                var house = new House
                {
                    Name = houserequest.Name,
                    Type = houserequest.Type,
                    Location = houserequest.Location,
                    Price = houserequest.Price,
                    Image = houserequest.Image,
                    NOfBath = houserequest.NOfBath,
                    NOfBed = houserequest.NOfBed,
                    Size = houserequest.Size,
                    Mode = houserequest.Mode

                };
                var createdHouse = await _repos.CreateHouseAsync(house);
                response.Data = createdHouse;
                response.Success = true;
                response.Message = " House created";
                    return response;
        }

        public async Task<HouseResponse<bool>> DeleteHouseAsync(int id)
        {
            var response = new HouseResponse<bool>();
            var deleted = await _repos.DeleteHouseAsync(id);
            response.Data = deleted;
            return response;
        }

        public async Task<HouseResponse<List<House>>> GetAllHouseAsync()
        {

            var response = new HouseResponse<List<House>>();
            var houses = await _repos.GetAllHouseAsync();
            response.Data = houses;
            return response;

        }

        public async Task<HouseResponse<House>> GetHouseByIdAsync(int id)
        {
            var response = new HouseResponse<House>();
            var house = await _repos.GetHouseByIdAsync(id);
            if(house == null)
            {
                response.Success = false;
                response.Message = "House not found";
                return response;
            }
            response.Data = house;
            return response;
        }

        public async Task<HouseResponse<House>> UpdateHouseAsync(int id, HouseRequest houseRequest)
        {
            var response = new HouseResponse<House>();
            var house = await _repos.GetHouseByIdAsync(id);
            if(house == null)
            {
                response.Success = false;
                response.Message = "House not found";
                return response;
            }
            house.Name = houseRequest.Name;
            house.Location = houseRequest.Location;
            house.Mode = houseRequest.Mode;
            house.Size = houseRequest.Size;
            house.Type = houseRequest.Type;
            house.Image = houseRequest.Image;
            house.Price = houseRequest.Price;
            house.NOfBath = houseRequest.NOfBath;
            house.NOfBed = houseRequest.NOfBed;
            var updateHouse = await _repos.UpdateHouseAsync(house);
            response.Data = updateHouse;
            return response;
           
           
        }
    }
}

