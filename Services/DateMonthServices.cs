using Microsoft.EntityFrameworkCore;
using StudentRatingBlazor.Models;

namespace StudentRatingBlazor.Services
{
    public class DateMonthsServices
    {
        private readonly StudentRatingContext _db;
        public DateMonthsServices(StudentRatingContext db)
        {
            _db = db;
        }
        public async Task<List<DateMonth>> GetDateMonths()
        {
            return await _db.DateMonths.ToListAsync();
        }
        public async Task<DateMonth> GetDateMonth(int id)
        {
            return await _db.DateMonths.FindAsync(id);
        }
        public async Task AddDateMonth(DateMonth dateMonth)
        {   
            _db.Add(dateMonth);
            await _db.SaveChangesAsync();
        }
        public async Task EditDateMonth(DateMonth dateMonth)
        {
            _db.DateMonths.Update(dateMonth);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteDateMonth(DateMonth dateMonth)
        {
            _db.DateMonths.Remove(dateMonth);
            await _db.SaveChangesAsync();
        }
    }
}
