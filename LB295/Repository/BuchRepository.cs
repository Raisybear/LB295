using LB295.Data;
using LB295.Models;
using LB295.Interfaces;
using LB295.Repository;

namespace LB295.Repository
{
    public class BuchRepository : IBuchRepository
    {
        private readonly DataContext _context;  

        public BuchRepository(DataContext context)
        {
            _context = context;
        }

        public bool BuchGelesen(int BuchId)
        {
            throw new NotImplementedException();
        }

        public Buch GetBuch(int Id)
        {
            throw new NotImplementedException();
        }

        public Buch GetBuch(string Name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Buch> GetBücher()
        {
            return _context.Buch.OrderBy(p => p.Id).ToList();
        }
    }
}
