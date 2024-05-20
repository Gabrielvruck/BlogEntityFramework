using BlogEntityFramework.Data;

class Program
{
    static void Main(string[] args)
    {
        using var context = new BlogDataContext();
    }
}
