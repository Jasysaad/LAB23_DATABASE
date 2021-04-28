using LAB23_DATABASE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LAB23_DATABASE.Repository
{
    public interface IMovieRepository
    {
        
        Task Create(MovieModel movie);
        Task Delete(int id);
        Task<bool> Exists(int id);
        Task<List<MovieModel>> Get();
        Task<MovieModel> Get(int id);
        Task Update(MovieModel movie);
    }
}
