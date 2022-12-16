using Microsoft.EntityFrameworkCore;
using StudentRatingBlazor.Models;

namespace StudentRatingBlazor.Services
{
    public class StudentsServices
    {
        private readonly StudentRatingContext _db;
        public StudentsServices(StudentRatingContext db)
        {
            _db = db;
        }
        public async Task<List<Student>> GetStudents()
        {
            return await _db.Students.ToListAsync();
        }
        public async Task<Student> GetStudent(int id)
        {
            return await _db.Students.FindAsync(id);
        }
        public async Task AddStudent(Student student)
        {   
            _db.Add(student);
            await _db.SaveChangesAsync();
        }
        public async Task EditStudent(Student student)
        {
            _db.Students.Update(student);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteStudent(Student student)
        {
            _db.Students.Remove(student);
            await _db.SaveChangesAsync();
        }
    }
}
