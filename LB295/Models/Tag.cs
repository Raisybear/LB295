namespace LB295.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        public string TagName { get; set; }

        public ICollection<Buch> Bücher { get; set; }
    }
}
