using ApiProjeKampi.WebApi.Dtos.ContactDtos;
using ApiProjeKampi.WebApi.Dtos.MessageDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;
namespace ApiProjeKampi.WebApi.Mapping

{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature,ResultContactDto>().ReverseMap();
            CreateMap<Feature,CreateContactDto>().ReverseMap();
            CreateMap<Feature,UpdateContactDto>().ReverseMap();
            CreateMap<Feature,GetByIdContactDto>().ReverseMap();

            CreateMap<Message,GetByIdMessageDto>().ReverseMap();
            CreateMap<Message,UpdateMessageDto>().ReverseMap();
            CreateMap<Message,CreateMessageDto>().ReverseMap();
            CreateMap<Message,ResultMessageDto>().ReverseMap();
            
        }
    }
}
