namespace CodeFirstRelation.Entities
{
    public class PostEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        //Relation Property

        public UserEntity User { get; set; }
    }
}
