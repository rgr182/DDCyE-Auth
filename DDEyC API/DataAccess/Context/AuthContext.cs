﻿using DDEyC_Auth.DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDEyC_API.DataAccess.Context
{
    public class AuthContext : DbContext
    {
        private static AuthContext? _instance;

        public AuthContext()
        {
        }

        public AuthContext(DbContextOptions<AuthContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Sessions> Sessions { get; set; }

        public static AuthContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AuthContext();
            }
            return _instance;
        }
    }
}
