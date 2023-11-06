using Laboratorium_3___PostApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___PostApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        public IActionResult Index()
        {
            return View(_postService.FindAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post model)
        {
            if (ModelState.IsValid)
            {
                //zapisz obiekt do bazy/kolekcji albo wykonaj operacje
                _postService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_postService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Post model)
        {
            if (ModelState.IsValid)
            {
                _postService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_postService.FindById(id));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_postService.FindById(id));
        }
        [HttpGet]
        public IActionResult Delete2(int id)
        {
            if (ModelState.IsValid)
            {
                _postService.Delete(id);
                return RedirectToAction("Index");
            }
            // Możesz obsłużyć błąd, jeśli kontakt o podanym ID nie istnieje.
            return RedirectToAction("Index");
        }
    }
}
