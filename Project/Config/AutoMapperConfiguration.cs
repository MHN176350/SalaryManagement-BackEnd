using AutoMapper;
using Project.DTO.Request;
using Project.Models;


namespace Project.Config
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<TakeLeaveReq, TakeLeave>();
        }
    }
}
