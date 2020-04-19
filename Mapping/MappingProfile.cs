using AutoMapper;
using VegaCore.Controllers.Resources;
using VegaCore.Models;

namespace VegaCore.Mapping
{
    public class MappingProfile: Profile
    {
     public MappingProfile()
     {
         CreateMap<Make, MakeResource>();
         CreateMap<Model, ModelResouce>();
         CreateMap<Feature, FeatureResource>();
     }
    }
}