using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
	public class Category
	{
        public int Id { get; set; }
		public string Name { get; set; }
    }
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public decimal Price { get; set; }
		public string Description { get; set; }
        public int CategoryId { get; set; }
		public Category Category { get; set; }
    }

	public class ProductService
	{
		private List<Product> products = new List<Product>();
        
        public ProductService()
        {
            // Kategorileri oluştur
            var elektronik = new Category { Id = 1, Name = "Elektronik" };
            var giyim = new Category { Id = 2, Name = "Giyim" };
            var ev = new Category { Id = 3, Name = "Ev & Yaşam" };

            // Elektronik ürünleri (25 adet)
            var elektronikUrunler = new[]
            {
                new Product { Id = 1, Name = "iPhone 15 Pro", Price = 45000m, Description = "Apple'ın en son amiral gemisi akıllı telefonu", CategoryId = 1, Category = elektronik },
                new Product { Id = 2, Name = "Samsung Galaxy S24", Price = 38000m, Description = "Samsung'un yeni nesil Android telefonu", CategoryId = 1, Category = elektronik },
                new Product { Id = 3, Name = "MacBook Pro M3", Price = 65000m, Description = "Profesyonel kullanım için güçlü laptop", CategoryId = 1, Category = elektronik },
                new Product { Id = 4, Name = "Dell XPS 13", Price = 42000m, Description = "İnce ve hafif ultrabook", CategoryId = 1, Category = elektronik },
                new Product { Id = 5, Name = "iPad Air", Price = 28000m, Description = "Taşınabilir ve güçlü tablet", CategoryId = 1, Category = elektronik },
                new Product { Id = 6, Name = "Sony WH-1000XM5", Price = 8500m, Description = "Gürültü önleyici kablosuz kulaklık", CategoryId = 1, Category = elektronik },
                new Product { Id = 7, Name = "AirPods Pro", Price = 7200m, Description = "Apple'ın kablosuz kulak içi kulaklığı", CategoryId = 1, Category = elektronik },
                new Product { Id = 8, Name = "Canon EOS R6", Price = 52000m, Description = "Profesyonel aynasız fotoğraf makinesi", CategoryId = 1, Category = elektronik },
                new Product { Id = 9, Name = "Nintendo Switch", Price = 8900m, Description = "Hibrit oyun konsolu", CategoryId = 1, Category = elektronik },
                new Product { Id = 10, Name = "PlayStation 5", Price = 18500m, Description = "Sony'nin yeni nesil oyun konsolu", CategoryId = 1, Category = elektronik },
                new Product { Id = 11, Name = "Apple Watch Series 9", Price = 12000m, Description = "Gelişmiş sağlık takip özellikli akıllı saat", CategoryId = 1, Category = elektronik },
                new Product { Id = 12, Name = "Samsung 55'' QLED TV", Price = 32000m, Description = "4K çözünürlüklü akıllı televizyon", CategoryId = 1, Category = elektronik },
                new Product { Id = 13, Name = "Logitech MX Master 3S", Price = 2800m, Description = "Profesyonel kablosuz mouse", CategoryId = 1, Category = elektronik },
                new Product { Id = 14, Name = "Mechanical Keyboard RGB", Price = 3500m, Description = "Oyun ve yazılım geliştirme için mekanik klavye", CategoryId = 1, Category = elektronik },
                new Product { Id = 15, Name = "JBL Charge 5", Price = 2200m, Description = "Taşınabilir Bluetooth hoparlör", CategoryId = 1, Category = elektronik },
                new Product { Id = 16, Name = "GoPro Hero 12", Price = 15000m, Description = "Su geçirmez aksiyon kamerası", CategoryId = 1, Category = elektronik },
                new Product { Id = 17, Name = "Xiaomi Mi Band 8", Price = 850m, Description = "Uygun fiyatlı fitness takip cihazı", CategoryId = 1, Category = elektronik },
                new Product { Id = 18, Name = "Dyson V15 Detect", Price = 18000m, Description = "Kablosuz süpürge", CategoryId = 1, Category = elektronik },
                new Product { Id = 19, Name = "Philips Hue Bulb", Price = 450m, Description = "Akıllı LED ampul", CategoryId = 1, Category = elektronik },
                new Product { Id = 20, Name = "Anker PowerBank 20000mAh", Price = 1200m, Description = "Yüksek kapasiteli taşınabilir şarj cihazı", CategoryId = 1, Category = elektronik },
                new Product { Id = 21, Name = "Tesla Model Y Araç Şarjı", Price = 8500m, Description = "Elektrikli araç şarj istasyonu", CategoryId = 1, Category = elektronik },
                new Product { Id = 22, Name = "Ring Video Doorbell", Price = 4200m, Description = "Akıllı kapı zili ve güvenlik kamerası", CategoryId = 1, Category = elektronik },
                new Product { Id = 23, Name = "Oculus Quest 3", Price = 24000m, Description = "Sanal gerçeklik başlığı", CategoryId = 1, Category = elektronik },
                new Product { Id = 24, Name = "DJI Mini 4 Pro", Price = 28000m, Description = "Kompakt drone kamera", CategoryId = 1, Category = elektronik },
                new Product { Id = 25, Name = "Samsung Galaxy Buds Pro", Price = 3800m, Description = "Kablosuz kulak içi kulaklık", CategoryId = 1, Category = elektronik }
            };

            // Giyim ürünleri (23 adet)
            var giyimUrunler = new[]
            {
                new Product { Id = 26, Name = "Levi's 501 Jean", Price = 1200m, Description = "Klasik kesim kot pantolon", CategoryId = 2, Category = giyim },
                new Product { Id = 27, Name = "Nike Air Max 270", Price = 2800m, Description = "Rahat günlük spor ayakkabı", CategoryId = 2, Category = giyim },
                new Product { Id = 28, Name = "Adidas Ultraboost 23", Price = 3200m, Description = "Koşu için tasarlanmış performans ayakkabısı", CategoryId = 2, Category = giyim },
                new Product { Id = 29, Name = "Zara Blazer Ceket", Price = 899m, Description = "İş ve günlük kullanım için şık blazer", CategoryId = 2, Category = giyim },
                new Product { Id = 30, Name = "H&M Organik Pamuk T-Shirt", Price = 189m, Description = "Sürdürülebilir pamuktan üretilen basic tişört", CategoryId = 2, Category = giyim },
                new Product { Id = 31, Name = "Uniqlo Heattech İç Çamaşır", Price = 299m, Description = "Isı tutan teknolojik iç giyim", CategoryId = 2, Category = giyim },
                new Product { Id = 32, Name = "Mango Deri Ceket", Price = 2400m, Description = "Gerçek deri motosiklet ceketi", CategoryId = 2, Category = giyim },
                new Product { Id = 33, Name = "Pull&Bear Hoodie", Price = 349m, Description = "Konforlu kapüşonlu sweatshirt", CategoryId = 2, Category = giyim },
                new Product { Id = 34, Name = "LC Waikiki Pijama Takımı", Price = 179m, Description = "Pamuklu rahat ev kıyafeti", CategoryId = 2, Category = giyim },
                new Product { Id = 35, Name = "Koton Elbise", Price = 459m, Description = "Günlük şık midi elbise", CategoryId = 2, Category = giyim },
                new Product { Id = 36, Name = "Defacto Çorap Seti", Price = 89m, Description = "5'li pamuklu çorap paketi", CategoryId = 2, Category = giyim },
                new Product { Id = 37, Name = "Marks&Spencer Gömlek", Price = 789m, Description = "İş için ideal klasik gömlek", CategoryId = 2, Category = giyim },
                new Product { Id = 38, Name = "Bershka Crop Top", Price = 199m, Description = "Yaz için kısa kesim bluz", CategoryId = 2, Category = giyim },
                new Product { Id = 39, Name = "Stradivarius Mom Jean", Price = 449m, Description = "Yüksek bel vintage jean", CategoryId = 2, Category = giyim },
                new Product { Id = 40, Name = "Puma Eşofman Takımı", Price = 1299m, Description = "Spor ve günlük kullanım için takım", CategoryId = 2, Category = giyim },
                new Product { Id = 41, Name = "New Balance 530 Sneaker", Price = 2100m, Description = "Retro tarzda günlük ayakkabı", CategoryId = 2, Category = giyim },
                new Product { Id = 42, Name = "Tommy Hilfiger Polo", Price = 1890m, Description = "Klasik polo yaka tişört", CategoryId = 2, Category = giyim },
                new Product { Id = 43, Name = "Calvin Klein İç Çamaşır", Price = 599m, Description = "Pamuklu boxer seti", CategoryId = 2, Category = giyim },
                new Product { Id = 44, Name = "Converse Chuck Taylor", Price = 1450m, Description = "İkonik canvas ayakkabı", CategoryId = 2, Category = giyim },
                new Product { Id = 45, Name = "Mavi Skinny Jean", Price = 689m, Description = "Dar kesim streç jean", CategoryId = 2, Category = giyim },
                new Product { Id = 46, Name = "Lacoste Polo Shirt", Price = 2200m, Description = "Lüks polo yaka tişört", CategoryId = 2, Category = giyim },
                new Product { Id = 47, Name = "Vans Old Skool", Price = 1750m, Description = "Skater tarzı günlük ayakkabı", CategoryId = 2, Category = giyim },
                new Product { Id = 48, Name = "Gap Chino Pantolon", Price = 899m, Description = "Günlük şık kumaş pantolon", CategoryId = 2, Category = giyim }
            };

            // Ev & Yaşam ürünleri (22 adet)
            var evUrunler = new[]
            {
                new Product { Id = 49, Name = "IKEA Malm Yatak Odası Takımı", Price = 8500m, Description = "Modern tasarım yatak odası mobilyaları", CategoryId = 3, Category = ev },
                new Product { Id = 50, Name = "Arzum Blendmax Blender", Price = 1200m, Description = "Güçlü mutfak blender'ı", CategoryId = 3, Category = ev },
                new Product { Id = 51, Name = "Tefal Cookware Set", Price = 2800m, Description = "10 parça tencere seti", CategoryId = 3, Category = ev },
                new Product { Id = 52, Name = "Philips Airfryer", Price = 3200m, Description = "Sağlıklı pişirme için hava fritözü", CategoryId = 3, Category = ev },
                new Product { Id = 53, Name = "Karcher Basınçlı Yıkama", Price = 1850m, Description = "Araç ve bahçe temizliği için basınçlı su makinesi", CategoryId = 3, Category = ev },
                new Product { Id = 54, Name = "Bosch Bulaşık Makinesi", Price = 12000m, Description = "Enerji tasarruflu bulaşık makinesi", CategoryId = 3, Category = ev },
                new Product { Id = 55, Name = "LG Çamaşır Makinesi", Price = 8900m, Description = "9 kg kapasiteli çamaşır makinesi", CategoryId = 3, Category = ev },
                new Product { Id = 56, Name = "Beko Buzdolabı No-Frost", Price = 15000m, Description = "Çifte kapı buzdolabı", CategoryId = 3, Category = ev },
                new Product { Id = 57, Name = "Xiaomi Robot Süpürge", Price = 4500m, Description = "Akıllı robot temizlik cihazı", CategoryId = 3, Category = ev },
                new Product { Id = 58, Name = "English Home Nevresim Takımı", Price = 450m, Description = "Pamuklu çift kişilik nevresim", CategoryId = 3, Category = ev },
                new Product { Id = 59, Name = "Madame Coco Kahve Fincan Seti", Price = 280m, Description = "6 kişilik porselen kahve takımı", CategoryId = 3, Category = ev },
                new Product { Id = 60, Name = "Spinway Halı 160x230", Price = 1200m, Description = "Modern desenli salon halısı", CategoryId = 3, Category = ev },
                new Product { Id = 61, Name = "Bellona Koltuk Takımı", Price = 18000m, Description = "3+3+1 modern koltuk takımı", CategoryId = 3, Category = ev },
                new Product { Id = 62, Name = "Bambum Mutfak Gereçleri", Price = 380m, Description = "Bambu mutfak araçları seti", CategoryId = 3, Category = ev },
                new Product { Id = 63, Name = "Schafer Tencere Seti", Price = 1890m, Description = "Paslanmaz çelik 8 parça tencere", CategoryId = 3, Category = ev },
                new Product { Id = 64, Name = "Goldmaster Elektrikli Süpürge", Price = 2200m, Description = "Torbalı güçlü elektrikli süpürge", CategoryId = 3, Category = ev },
                new Product { Id = 65, Name = "Creavit Banyo Seti", Price = 890m, Description = "Modern banyo aksesuarları", CategoryId = 3, Category = ev },
                new Product { Id = 66, Name = "Linens Havlu Takımı", Price = 320m, Description = "Pamuklu banyo havlu seti", CategoryId = 3, Category = ev },
                new Product { Id = 67, Name = "Pasabahce Cam Seti", Price = 450m, Description = "18 parça cam bardak ve tabak seti", CategoryId = 3, Category = ev },
                new Product { Id = 68, Name = "Sinbo Elektrikli Kettle", Price = 285m, Description = "Paslanmaz çelik su ısıtıcısı", CategoryId = 3, Category = ev },
                new Product { Id = 69, Name = "Arçelik Tost Makinesi", Price = 650m, Description = "4 dilim kapasiteli ekmek kızartma makinesi", CategoryId = 3, Category = ev },
                new Product { Id = 70, Name = "Falez Ayna 80x60", Price = 480m, Description = "Modern çerçeveli duvar aynası", CategoryId = 3, Category = ev }
            };

            // Tüm ürünleri listeye ekle
            products.AddRange(elektronikUrunler);
            products.AddRange(giyimUrunler);
            products.AddRange(evUrunler);
        }

		public List<Product> GetProducts()
		{
			return products;
		}
    }
}
