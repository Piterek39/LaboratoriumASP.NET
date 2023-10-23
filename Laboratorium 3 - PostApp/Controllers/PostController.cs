using Laboratorium_3___PostApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___PostApp.Controllers
{
    public class PostController : Controller
    {
        static readonly Dictionary<int, Post> _posts = new Dictionary<int, Post>();
        static int index = 1;
        public IActionResult Index()
        {
            return View(_posts);
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
                model.Id = index++;
                model.PostDate = DateTime.Now;
                _posts[model.Id] = model;               
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_posts[id]);
        }
        [HttpPost]
        public IActionResult Update(Post model)
        {
            if (ModelState.IsValid)
            {
                _posts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_posts[id]);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_posts[id]);
        }
        [HttpGet]
        public IActionResult Delete2(int id)
        {
            if (_posts.ContainsKey(id))
            {
                _posts.Remove(id);
                return RedirectToAction("Index");
            }
            // Możesz obsłużyć błąd, jeśli kontakt o podanym ID nie istnieje.
            return RedirectToAction("Index");
        }
    }
}
