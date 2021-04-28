using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB23_DATABASE.Models;

namespace LAB23_DATABASE.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieDbContext _context)
        {
            _context.Database.EnsureCreated();

            if (_context.Movies.Any())
            {
                return;
            }

            _context.Movies.AddRange(new[] {
                new MovieModel
                {
                    Title = "Fury",
                    Genre = "Action",
                    //ID = 1,
                    RunTime = 180

                },

                new MovieModel
                {

                   Title =  "Mummy",
                   Genre = "SciFi",
                   //ID = 0,
                   RunTime = 180
                },

            });
            _context.SaveChanges();

        }
    }
}
