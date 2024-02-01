    using System;
    using HouseRenting.Server.Data;
    using HouseRenting.Share.Entities;
    using Microsoft.EntityFrameworkCore;

    namespace HouseRenting.Server.Repositories
    {
   
	    public class HouseRepository: IHouseRepository
        {
            private  readonly AppDbContext _context;

            public HouseRepository(AppDbContext context)
		    {
                _context = context;
		    }

            public async  Task<House> CreateHouseAsync(House house)
            {
               _context.Houses.Add(house);
                await _context.SaveChangesAsync();
                return house;

            }

            public async Task<bool> DeleteHouseAsync(int id)
            {
                var house = await GetHouseByIdAsync(id);
                _context.Remove(house);
                await _context.SaveChangesAsync();
                return true;

            }

            public async Task<List<House>> GetAllHouseAsync()
            {
          
                return await _context.Houses.ToListAsync();
            }

            public async Task<House> GetHouseByIdAsync(int id)
            {
                return await  _context.Houses.FindAsync(id);
            }

           

            public async Task<House> UpdateHouseAsync(House house)
            {
                _context.Houses.Update(house);
               await _context.SaveChangesAsync();
                return house;
            }
        }
    }

