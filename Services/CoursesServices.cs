using Microsoft.EntityFrameworkCore;
using StudentRatingBlazor.Models;
using StudentRatingBlazor.Services;

namespace StudentRatingBlazor.Services
{
    public class CoursesServices
    {
        private readonly StudentRatingContext _db;
        private readonly TeachersServices _tc;
        public CoursesServices(StudentRatingContext db)
        {
            _db = db;
            _tc = new TeachersServices(db);
        }
        public async Task<List<Course>> GetCourses()
        {
            return await _db.Courses.Include(c => c.Teacher).ToListAsync();
        }
        public async Task<List<Teacher>> GetTeachers()
        {
            return await _tc.GetTeachers();
        }
        public async Task<Course> GetCourse(int id)
        {
            return await _db.Courses.FindAsync(id);
        }
        public async Task AddCourse(Course course)
        {   
            _db.Add(course);
            await _db.SaveChangesAsync();
        }
        public async Task EditCourse(Course course)
        {
            _db.Courses.Update(course);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteCourse(Course course)
        {
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
        }
    }
}
