using System;
using System.Net.Http.Json;
using HouseRenting.Share.Entities;
using Housereting.Share.HouseDTOs;

namespace HouseReting.Client.Services
{
    public class ServiceClient : IServiceClient
    {
        private readonly HttpClient _httpClient;
        public ServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HouseResponse<House>> CreateHouseAsync(HouseRequest house)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/house", house);
            var response = await result.Content.ReadFromJsonAsync<HouseResponse<House>>();

            return response!;
        }

        public async Task<HouseResponse<bool>> DeleteHouseAsync(int Id)
        {
            var result = await _httpClient.GetAsync("api/house/{id}");
            var response = await result.Content.ReadFromJsonAsync<HouseResponse<bool>>();
            return response!;
        }

        public async Task<HouseResponse<List<House>>> GetAllHouseAsync()
        {
            var result = await _httpClient.GetAsync("api/house");
            var response = await result.Content.ReadFromJsonAsync<HouseResponse<List<House>>>();
            return response!;

        }

        public async Task<HouseResponse<House>> GetHouseByIdAsync(int id)
        {
            var result = await _httpClient.GetAsync($"api/house/{id}");
            var response = await result.Content.ReadFromJsonAsync<HouseResponse<House>>();
            return response!;
        }

        public  async Task<HouseResponse<House>> UpdateHouseAsync(int id, HouseRequest houseRequest)
        {
            var result = await _httpClient.PutAsJsonAsync("api/house", houseRequest);
            var response = await result.Content.ReadFromJsonAsync<HouseResponse<House>>();
            return response!;
        }
    }
}

