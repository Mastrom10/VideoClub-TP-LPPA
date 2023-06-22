using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoClub.Data;
using VideoClub.Models;


namespace VideoClub.Controllers
{
    public class PeliculasController : Controller
    {
       /* DALPeliculas Methods:
        List<Pelicula> GetPeliculas();
        Pelicula GetPelicula(int id);
        void InsertPelicula(Pelicula pelicula);
        void UpdatePelicula(int id, Pelicula pelicula);
        void DeletePelicula(int id);
       */


        // GET: Peliculas
        public IActionResult Index()
        {
            // Aquí debes traer todas las peliculas de tu base de datos y devolverlas a la vista
            List<Pelicula> peliculas = new DALPeliculas().GetPeliculas();
            return View(peliculas);
        }

        // GET: Peliculas/Details/5
        public IActionResult Details(int id)
        {
            // Aquí debes buscar la pelicula con el id especificado en tu base de datos y devolverla a la vista
            Pelicula pelicula = new DALPeliculas().GetPelicula(id); 

            return View(pelicula);
        }

        // GET: PeliculasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeliculasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pelicula pelicula)
        {
            try
            {
                // Aquí debes agregar la pelicula a tu base de datos
                new DALPeliculas().InsertPelicula(pelicula);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculasController/Edit/5
        public ActionResult Edit(int id)
        {

            // Aquí debes buscar la pelicula con el id especificado en tu base de datos y devolverla a la vista
            Pelicula pelicula = new DALPeliculas().GetPelicula(id);

            return View(pelicula);
        }

        // POST: PeliculasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Pelicula pelicula)
        {
            try
            {
                // Aquí debes actualizar la pelicula en tu base de datos
                new DALPeliculas().UpdatePelicula(id, pelicula);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculasController/Delete/5
        public ActionResult Delete(int id)
        {
            // Aquí debes buscar la pelicula con el id especificado en tu base de datos y devolverla a la vista
            Pelicula pelicula = new DALPeliculas().GetPelicula(id);

            return View(pelicula);
        }

        // POST: PeliculasController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // Aquí debes eliminar la pelicula de tu base de datos
               new DALPeliculas().DeletePelicula(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
