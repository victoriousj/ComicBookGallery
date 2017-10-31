using ComicBookGallery.Data;
using System.Web.Mvc;

namespace ComicBookGaller.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }
    }
}