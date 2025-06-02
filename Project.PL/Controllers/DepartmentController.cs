using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interfaces;
using Project.DAL.Models;

namespace Project.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        // GET: Department
        public ActionResult Index()
        {
            var departments = _departmentRepository.GetAll();
            return View(departments);
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            if (!ModelState.IsValid)
                return View(department);

            _departmentRepository.Add(department);
            return RedirectToAction("Index");
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        // POST: Department/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department department)
        {
            if (!ModelState.IsValid)
                return View(department);

            _departmentRepository.Update(department);
            return RedirectToAction("Index");
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department == null)
                return NotFound();

            _departmentRepository.Delete(department);
            return RedirectToAction("Index");
        }
    }
}
