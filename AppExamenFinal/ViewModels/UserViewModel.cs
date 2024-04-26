﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppExamenFinal.Models;

namespace AppExamenFinal.ViewModels
{
    public class UserViewModel : BaseViewModel
    {

        public UserRole MyUserRole { get; set; }
        public UserViewModel()
        {
            
            MyUserRole = new UserRole();
        }

        //carga de roles de usuarios
        public async Task<List<UserRole>?> GetAllUserRolesAsync()
        {
            try
            {
                List<UserRole> roles = new List<UserRole>();

                roles = await MyUserRole.GetAllUserRolesAsync();

                if (roles == null)
                {
                    return null;
                }
                return roles;
            }
            catch (Exception)
            {
                throw;
            }


        }

        
    }
}
