namespace WebAPI_with_Blazor.Models.Entities.DbSet
{

    /// <summary>
    /// 
    /// </summary>
    public class User : BaseEntity
    {
        //fields

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public DateTime Date { get; set; }
        public String Country { get; set; }
    }
}
