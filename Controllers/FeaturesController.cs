using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VegaCore.Controllers.Resources;
using VegaCore.Models;
using VegaCore.Persistence;

namespace VegaCore.Controllers
{
    public class FeaturesController: Controller
    {
        private readonly VegaCoreDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(VegaCoreDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet("api/features")]
        public async Task<IEnumerable<Resources.KeyValuePairResource>> GetFeatures()
        {
           var features = await _context.Features.ToListAsync();
           return _mapper.Map<List<Feature>, List<Resources.KeyValuePairResource>>(features);
        }
    }
}