namespace CodeFirstRelation.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
