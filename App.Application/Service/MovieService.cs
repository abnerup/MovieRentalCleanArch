using App.Application.Repository.Interface;
using App.Application.Service.Interface;
using App.Domain.Entities;

namespace App.Application.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<List<Movie>> CreateMovie(Movie movie)
        {
            var list =  await _movieRepository.CreateMovie(movie);
            return list;
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            var list = await _movieRepository.GetAllMovies();
            return list;
        }
    }
}