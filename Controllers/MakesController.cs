using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VegaCore.Controllers.Resources;
using VegaCore.Models;
using VegaCore.Persistence;

namespace VegaCore.Controllers{
    public class MakesController : Controller
    {
        private readonly VegaCoreDbContext _context;
        private readonly IMapper _mapper;

        public MakesController(VegaCoreDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        } 
        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes(){
          var makes = await _context.Makes.Include(m => m.Models).ToListAsync();
          return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}