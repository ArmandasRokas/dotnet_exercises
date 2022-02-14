namespace webapi_vs.Data
{
    public static class Extensions
    {
        public static void CreateDbIfNotExists(this IHost host)
        {
            Console.WriteLine("In CreateDbIfNotExists");
            {
                using (var scope = host.Services.CreateScope())
                {
                    Console.WriteLine("1");
                    var services = scope.ServiceProvider;
                    var context = services.GetRequiredService<PizzaContext>();
                    //if (context.Database.EnsureCreated())
                    //{
                        Console.WriteLine("2");
                        DbInitializer.Initialize(context);
                    //}
                }
            }
        }
    }
}
