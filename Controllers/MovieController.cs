using Microsoft.AspNetCore.Http;
using LAB23_DATABASE.Models;
using LAB23_DATABASE.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB23_DATABASE.Data;
using LAB23_DATABASE.Repository;

namespace LAB23_DATABASE.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repo;
        public MovieController(IMovieRepository repo)
        {
            _repo = repo;
        }
        

        public IActionResult Index()
        {

            return View();
        }



        //GET: MovieController/Sear
            public async Task<IActionResult> SearchResultGenre(MovieModel model)
        {
            var result = await _repo.Get(); 
            var list =   result.Where(x => x.Genre == model.Genre);
            return View(list);
        }
        // GET: MovieController/Details/5
        public async Task<IActionResult> SearchResultTitle(MovieModel model)
        {
            var result = await _repo.Get();
            var list = result.Where(x => x.Title.Contains(model.Title));
            return View(list);
        }

    }
}
