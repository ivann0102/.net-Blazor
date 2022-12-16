using Microsoft.EntityFrameworkCore;
using StudentRatingBlazor.Models;

namespace StudentRatingBlazor.Services
{
    public class TeachersServices
    {
        private readonly StudentRatingContext _db;
        public TeachersServices(StudentRatingContext db)
        {
            _db = db;
        }
        public async Task<List<Teacher>> GetTeachers()
        {
            return await _db.Teachers.ToListAsync();
        }
        public async Task<Teacher> GetTeacher(int id)
        {
            return await _db.Teachers.FindAsync(id);
        }
        public async Task AddTeacher(Teacher teacher)
        {   
            _db.Add(teacher);
            await _db.SaveChangesAsync();
        }
        public async Task EditTeacher(Teacher teacher)
        {
            _db.Teachers.Update(teacher);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteTeacher(Teacher teacher)
        {
            _db.Teachers.Remove(teacher);
            await _db.SaveChangesAsync();
        }
    }
}
