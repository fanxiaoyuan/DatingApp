using System;
using System.Collections.Generic;
using DatingApp.API.Model;

namespace DatingApp.API.Dtos
{
    public class UserForDetailedDto : UserForListDto
    {
        public DateTime LastActivat { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}