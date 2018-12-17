using ComicBookGallery.Data;
using System.Web.Mvc;

namespace ComicBookGaller.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController() =>
            _comicBookRepository = new ComicBookRepository();

        public ActionResult Detail(int? id) => 
			View(_comicBookRepository.GetComicBook(id.Value));

        public ActionResult Index() =>
            View(_comicBookRepository.GetComicBooks());
    }
}