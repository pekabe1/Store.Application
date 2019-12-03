﻿using Store.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Application.Services
{
    public interface IUserService
    {
        Task<string> LoginAsync(UserViewModel userViewModel);
    }
}
