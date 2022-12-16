using Microsoft.EntityFrameworkCore;
using StudentRatingBlazor.Models;
using StudentRatingBlazor.Services;

namespace StudentRatingBlazor.Services
{
    public class RatingsServices
    {
        private readonly StudentRatingContext _db;
        private readonly CoursesServices _cs;
        private readonly StudentsServices _sts;
        private readonly DateMonthsServices _dms;
        public RatingsServices(StudentRatingContext db)
        {
            _db = db;
            _cs = new CoursesServices(db);
            _sts = new StudentsServices(db);
            _dms = new DateMonthsServices(db);
        }
        public async Task<List<Rating>> GetRatings()
        {
            return await _db.Ratings.Include(r => r.Course).Include(r => r.Student).ToListAsync();
        }
        public async Task<List<Course>> GeCourses()
        {
            return await _cs.GetCourses();
        }
        public async Task<List<Student>> GetStudents()
        {
            return await _sts.GetStudents();
        }
        public async Task<List<DateMonth>> GetDateMonths()
        {
            return await _dms.GetDateMonths();
        }
        public async Task<Rating> GetRating(int id)
        {
            return await _db.Ratings.FindAsync(id);
        }
        public async Task AddRating(Rating rating)
        {   
            _db.Add(rating);
            await _db.SaveChangesAsync();
        }
        public async Task EditRating(Rating rating)
        {
            _db.Ratings.Update(rating);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteRating(Rating rating)
        {
            _db.Ratings.Remove(rating);
            await _db.SaveChangesAsync();
        }
    }
}
