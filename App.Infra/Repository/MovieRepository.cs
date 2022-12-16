using App.Application.Repository.Interface;
using App.Domain.Entities;
using App.Infra.Context;

namespace App.Infra.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _dataContext;

        public MovieRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Movie>> CreateMovie(Movie movie)
        {
            _dataContext.Movies.Add(movie);
            await _dataContext.SaveChangesAsync();
           
            return await GetAllMovies();
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            var movies = await _dataContext.Movies.ToListAsync();
            return movies;
        }
     
    }
}