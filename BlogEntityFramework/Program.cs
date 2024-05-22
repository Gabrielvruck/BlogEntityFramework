using BlogEntityFramework.Data;
using BlogEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using var context = new BlogDataContext();
        var posts = GetPosts(context, 1, 25);

        //mando pegar o author e dentro de author mando buscar roles.
        var posts2 = context.Posts.Include(p => p.Author).ThenInclude(p => p.Roles).ToList();
    }

    public static List<Post> GetPosts(BlogDataContext context, int skip = 0, int take = 25)
    {
        var posts = context.Posts.AsNoTracking().Skip(skip).Take(take).ToList();
        return posts;
    }
}
