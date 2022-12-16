using App.Domain.Entities;

namespace App.Application.Service.Interface
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMovies();
        Task<List<Movie>> CreateMovie(Movie movie);
    }
}
