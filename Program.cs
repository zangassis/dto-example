var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("/v1/sellers", (AppDbContext context) =>
{
    var sellers = context.Sellers;

    var sellersDtoList = new List<SellerDto>();

    if (sellers is not null)
    {
        foreach (var seller in sellers)
        {
            var sellerDto = new SellerDto(seller.Name, seller.Email);

            sellersDtoList.Add(sellerDto);
        }
    }

    return sellersDtoList.Count > 0 ? Results.Ok(sellersDtoList) : Results.NotFound();

}).Produces<Seller>();

app.MapGet("/", () => "Hello World!");

app.Run();
