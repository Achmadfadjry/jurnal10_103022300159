using Microsoft.AspNetCore.Mvc;
using modul10_103022300159;

namespace modul10_103022300159.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieControllers : ControllerBase
    {
        private static List<Movie> movieList = new List<Movie>
        { 
        new Movie("The Shawshank Redemption", "Frank Darabant", ["Tim Robbins", "Morgan freeman", "bob gunton", "william sadler"], "Two imprisoned men band over a number of years,finding solace and eventual redemption through act of common decency"),
        new Movie("The god father", "Francis ford copolla", ["marlan brando", "al pacino", "james caan", "diane kaetan"], "the aging partiach of an organized crime dynasty in postwar new york city transfer control of his clandesitine empire to recultant youngest son"),
        new Movie("the dark night", "christopher nolan", ["cristian bale", "heath ledger", "aoron eckhart", "michael coine"], "gandalf and arogorn lead the worold of men againnst of men suran army to draw his gaze from frado and som as they approach mount doom with the one ring"),

        };
[HttpGet]
public ActionResult<IEnumerable<Movie>> GetAll()
{
    return Ok(movieList);
}

[HttpGet("{index}")]
public ActionResult<Movie> GetByIndex(int index)
{
    if (index < 0 || index >= movieList.Count)
        return NotFound("Index tidak ditemukan.");

    return Ok(movieList[index]);
}

[HttpPost]
public ActionResult AddMovie([FromBody] Movie newMovie)
{
    movieList.Add(newMovie);
    return Ok("Movie berhasil ditambahkan.");
}

[HttpDelete("{index}")]
public ActionResult DeleteMovie(int index)
{
    if (index < 0 || index >= movieList.Count)
        return NotFound("Index tidak ditemukan.");

    movieList.RemoveAt(index);
    return Ok("Movie berhasil dihapus.");
}
    }
}


