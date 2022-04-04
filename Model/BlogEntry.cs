
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_blog.Models;

public class BlogEntry
{
    public uint BlogEntryId { get; set; }
    public string Title { get; set; } = "Blog Entry Title";
    public string Content { get; set; } = "";
    
    [DataType(DataType.DateTime)]
    [Column(TypeName = "DATETIME")]
    public DateTime TimePosted { get; set; } = DateTime.Now;
}