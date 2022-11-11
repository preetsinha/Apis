using AutoMapper;
using Book_Api_Laibrary.DTOs;
using Book_Api_Laibrary.Models;

namespace Book_Api_Laibrary
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<BookLiabrary, BookLaibrary>();
        }
    }
}
