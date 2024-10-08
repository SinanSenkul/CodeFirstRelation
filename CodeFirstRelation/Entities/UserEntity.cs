namespace CodeFirstRelation.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string UserName { get; set; }

        //Realaiton porperty

        public List<PostEntity> Posts { get; set; }
    }
}
