using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BLL.Interfaces;
using Project.DAL.Data;
using Project.DAL.Models;

namespace Project.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _dbContext;
        public DepartmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Department department)
        {
            _dbContext.Departments.Add(department);
            return _dbContext.SaveChanges();
        }

        public int Delete(Department department)
        {
            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbContext.Departments.ToList();
        }

        public Department GetById(int id)
        {
            var Db = _dbContext.Departments.Local.Where(D=> D.Id == id).FirstOrDefault();
            if (Db == null)
            {
                var DbS = _dbContext.Departments.Local.Where(D => D.Id == id).FirstOrDefault();
                return DbS;
            }
            return Db;

            // instead of using Local, you can use AsNoTracking() to avoid tracking changes if you don't need it
            // return _dbContext.Departments.AsNoTracking().FirstOrDefault(d => d.Id == id);
            // return _dbContext.Departments.Find(id); // This will also work, but it will not use Local tracking
        }

        public int Update(Department department)
        {
            _dbContext.Update(department);
            return _dbContext.SaveChanges();
        }
    }
}
