using Microsoft.EntityFrameworkCore;

namespace blazor_blog.Models;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

    public  DbSet<BlogEntry>? Blog {get;set;}

}