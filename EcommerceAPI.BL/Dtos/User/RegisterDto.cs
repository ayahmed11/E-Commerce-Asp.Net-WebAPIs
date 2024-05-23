using E_CommerceProject.DAL.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.User
{
    public record RegisterDto(string UserName, string Email, string Password, string PhoneNumber, int Age, Gender Gender, string Address);

}
