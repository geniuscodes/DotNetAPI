namespace WebAPI_with_Blazor.Models.Entities.DbSet
{

    /// <summary>
    /// This Class will hold abstract properties
    /// </summary>
    public abstract  class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Status { get; set; } = 1;//overides the Hard Delete
        public DateTime AddedDate { get; set; } = DateTime.UtcNow; 
        public DateTime UpdateDate { get; set; }

    }
}
