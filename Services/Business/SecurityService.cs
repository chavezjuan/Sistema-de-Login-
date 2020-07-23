﻿using shadApp.Models;
using shadApp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shadApp.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(UserModel user)
        {
            return daoService.FindByUser(user);
        }
    }
}