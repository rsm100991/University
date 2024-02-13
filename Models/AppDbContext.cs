﻿using Microsoft.EntityFrameworkCore;

namespace University.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            :base(options)
        {
                
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Response> AssignRooms { get; set; }

    }
}
