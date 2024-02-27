using LB295.Models;

namespace LB295.Interfaces
{
    public interface IBuchRepository
    {
        ICollection<Buch> GetBücher();

        Buch GetBuch(int Id);

        Buch GetBuch(string Name);

        bool BuchGelesen(int BuchId);   
    }
}
