using LAB23_DATABASE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB23_DATABASE.Data;
using Microsoft.EntityFrameworkCore;

namespace LAB23_DATABASE.Repository
{
    public class MovieRepository : IMovieRepository
    {

        //from J+R, going to try below instead. Don't want to use lists
        //private readonly List<MovieModel> _movie = new List<MovieModel>();

        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public async Task<List<MovieModel>> Get()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<MovieModel> Get(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);
        }

        public async Task Create(MovieModel movie)
        {
            _context.Add(new MovieModel("Mummy", "SciFi", 0, 180));
            _context.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await _context.Movies.AnyAsync(e => e.ID == id);
        }

       
        //public List<MovieModel> Get()
        //{
        //    var _movie = new List<MovieModel>();


        //    _movie.Add(new MovieModel("Mummy", Genre.SciFi, 0, 180));
        //    _movie.Add(new MovieModel("27 Dresses", Genre.Drama, 1, 180));
        //    _movie.Add(new MovieModel("The Nun", Genre.Horror, 2, 180));
        //    _movie.Add(new MovieModel("Martian", Genre.SciFi, 3, 180));
        //    _movie.Add(new MovieModel("Alien", Genre.Action, 4, 180));
        //    _movie.Add(new MovieModel("The Road", Genre.SciFi, 5, 180));
        //    _movie.Add(new MovieModel("Borat", Genre.Comedy, 6, 180));
        //    _movie.Add(new MovieModel("How to Lose a Guy in 10 Days", Genre.Drama, 7, 180));
        //    _movie.Add(new MovieModel("The Vow", Genre.Drama, 8, 180));
        //    _movie.Add(new MovieModel("RAMBO: First Blood", Genre.Action, 9, 180));
        //    _movie.Add(new MovieModel("The Expendables", Genre.Action, 10, 180));
        //    _movie.Add(new MovieModel("Failure to Launch", Genre.Drama, 11, 180));
        //    _movie.Add(new MovieModel("Meet the Fockers", Genre.Comedy, 12, 180));
        //    _movie.Add(new MovieModel("Nacho Libre", Genre.Comedy, 13, 180));
        //    _movie.Add(new MovieModel("Evil Dead", Genre.Horror, 14, 180));
        //    _movie.Add(new MovieModel("The Hangover", Genre.Comedy, 15, 180));
        //    _movie.Add(new MovieModel("Superbad", Genre.Comedy, 16, 180));
        //    _movie.Add(new MovieModel("Pineapple Express", Genre.Comedy, 17, 180));
        //    return _movie;
            
        //}

        public async Task Update(MovieModel movie)
        {
            _context.Update(movie);
            await _context.SaveChangesAsync();
        }

        //Task<List<MovieModel>> IMovieRepository.Get()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
