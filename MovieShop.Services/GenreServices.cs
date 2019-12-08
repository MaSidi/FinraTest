using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Entities;
using MovieShop.Data;
using System.Linq;

namespace MovieShop.Services
{
    public class GenreServices : IGenreServices
    {
        protected readonly IGenreRepository _genreRepository;
        public GenreServices(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
           var genres= await _genreRepository.GetAllAsync();
            return genres.OrderBy(g=>g.name);
        }
    }
}
