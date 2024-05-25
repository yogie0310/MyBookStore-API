namespace MyBookStore.API.Data.Models
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title= "Test Book Title",
                        Description= "Test Book Description",
                        IsRead= true,
                        DateRead= DateTime.Now.AddDays(-10),
                        Rating = 4,
                        Genre=  "Biography",
                        Author="Yogender",
                        CoverUrl="https....",
                        DateAdded= DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }

}
