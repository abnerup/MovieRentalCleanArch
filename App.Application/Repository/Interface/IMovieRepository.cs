

using App.Domain.Entities;

namespace App.Application.Repository.Interface
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMovies();
        Task<List<Movie>> CreateMovie(Movie movie);
    }
}
