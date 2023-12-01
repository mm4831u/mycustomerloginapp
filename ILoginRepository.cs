using CoreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycustomerloginapp.Services
{
    public interface ILoginRespository
    {
        Task<UserInfo> Login(string username, string password);
    }
}
