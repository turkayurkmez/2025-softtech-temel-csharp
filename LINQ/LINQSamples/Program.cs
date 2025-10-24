// See https://aka.ms/new-console-template for more information
using LINQSamples;

Console.WriteLine("Hello, World!");

var productService = new ProductService();
var allProducts = productService.GetProducts();

var justNameAndPriceOfProducts = allProducts.Select(p => new { UrunAdi = p.Name, Fiyat = p.Price })
                                            .ToList();

Console.WriteLine(new string('-', 20));
Console.WriteLine("Tüm Ürünler");
Console.WriteLine(new string('-',20));
justNameAndPriceOfProducts.ForEach(dto => Console.WriteLine($"{dto.UrunAdi}{new string('.',5)}{dto.Fiyat}"));


List<Product> getProductsBetweenPrices(List<Product> products, decimal minPrice,  decimal maxPrice) => products.Where(p=>p.Price >= minPrice &&  p.Price <= maxPrice)
             .OrderBy(p=>p.Price)
             .ToList();


Console.WriteLine(new string('-', 20));

var betweenResult = getProductsBetweenPrices(allProducts, 500, 2000);
Console.WriteLine("500 - 2000 TL Arası Ürünler");
Console.WriteLine(new string('-', 20));

betweenResult.ForEach(r => Console.WriteLine($"{r.Name}, {r.Price} TL - {r.Category.Name}"));

Console.WriteLine(new string('-', 20));

//en pahalı ürünün fiyatı:
var maxPrice = allProducts.Max(p => p.Price);
Console.WriteLine($"En pahalı ürünün fiyatı: {maxPrice}");
Console.WriteLine(new string('-', 20));
Console.WriteLine($"En pahalı ürün: {allProducts.MaxBy(p=>p.Price).Name}");
Console.WriteLine(new string('-', 20));
Console.WriteLine("--- En pahalı 10 ürün ---");
var topTenExpensives = allProducts.OrderByDescending(x => x.Price)
                                  .Take(10)
                                  .ToList();

topTenExpensives.ForEach(p => Console.WriteLine($" {p.Name} ({p.Price} TL)"));
Console.WriteLine(new string('-', 20));


//kategoriye göre gruplama:

var categoryStats = allProducts.GroupBy(p => p.Category)
                               .Select(g => new
                               {
                                   CategoryName = g.Key.Name,
                                   ProductCount = g.Count(),
                                   AveragePrice = g.Average(p => p.Price),
                                   MaxPrice = g.Max(p => p.Price),
                                   MinPrice = g.Min(p => p.Price),
                                   TotalPrice = g.Sum(p => p.Price)
                               })
                               .ToList();


Console.WriteLine("kategoriye göre ürün detayları");
Console.WriteLine(new string('-', 20));
Console.WriteLine("Kategori Adı....Ürün Adedi....Ortalama....Max....Min....Toplam");
foreach (var category in categoryStats)
{
    Console.WriteLine($"{category.CategoryName}....{category.ProductCount}....{category.AveragePrice}....{category.MaxPrice}....{category.MinPrice}....{category.TotalPrice}");
}

var productChunks = allProducts.Chunk(8);

int chunkNo = 1;
foreach (var pChunk in productChunks)
{
    Console.WriteLine($"{chunkNo++}. Chunk");
    for (int i = 0; i < pChunk.Length; i++)
    {
        Console.WriteLine($"[{i}.] {pChunk[i].Name}");
    }
}

var countByResult = allProducts.CountBy(p => p.Category);
foreach (var item in countByResult)
{
    Console.WriteLine($"{item.Key.Name} - {item.Value}");
}

var productDetail = allProducts.FirstOrDefault(p => p.Id == 5);

var singleDifference = allProducts.SingleOrDefault(p => p.Id == 6);

var lookingLookUp = allProducts.ToLookup(p => p.CategoryId);
foreach (var item in lookingLookUp)
{
   
    var lookResult = item.Select(g=>g.Name);

    lookResult.ToList().ForEach( x => Console.WriteLine(item.Key + "-"+ x));
    Console.WriteLine("--------------------------");
}







