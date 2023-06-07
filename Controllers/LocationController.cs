using Crud_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;

namespace Crud_Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LocationController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public LocationController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet(Name = "FetchCountryList")]
        public async Task<IEnumerable<Country>> CountryList()
        {
            return await _dbContext.country.FromSqlRaw<Country>("exec [newschema].[fetchcountry]").ToListAsync();
        }

        [HttpPost(Name = "ModifyCountry")]
        public async Task<IEnumerable<MessageModel>> ModifyCountry(Country c)
        {
            return await _dbContext.message.FromSqlRaw<MessageModel>($"exec [newschema].[modifycountry] @aed=N'{c.aed}', @countryid = {c.countryid}, @countryname = N'{c.countryname}'").ToListAsync();
        }


        [HttpGet(Name = "FetchStateList")]
        public async Task<IEnumerable<States>> StateList()
        {
            return await _dbContext.states.FromSqlRaw<States>("exec [newschema].[fetchstates]").ToListAsync();
        }

        [HttpPost(Name = "ModifyState")]
        public async Task<IEnumerable<MessageModel>> ModifyState(States c)
        {
            return await _dbContext.message.FromSqlRaw<MessageModel>($"exec [newschema].[modifystates] @aed=N'{c.aed}',@stateid = {c.stateid}, @countryid = {c.countryid}, @statename = N'{c.statename}'").ToListAsync();
        }

    }
}