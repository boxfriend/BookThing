using SQLite;

namespace BookThing.Data;

[Table("Books")]
public class BookData
{
    [PrimaryKey,AutoIncrement,Column("_id")] public int ID { get; set; }
    [MaxLength(64), Unique] public string Title { get; set; }
    [MaxLength(64)] public string Author { get; set; }
    public string Description { get; set; }
    [MaxLength(32)] public string Genre { get; set; }
    public bool Read { get; set; }
}
