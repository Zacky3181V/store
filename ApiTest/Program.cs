using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ApiTest
{
    internal class Program
    {
        

        public class Content
        {
            public string? id;
            public string? storeId;
            public string? billboardId;
            public string? name;
            public DateTime createdAt;
            public DateTime updatedAt;
        }

        public class Product
        {
            public string Name { get; set; }
            public List<Image> Images { get; set; }
            public Color Color { get; set; }
            public Category Category { get; set; }
            public Size Size { get; set; }
        }

        public class Image
        {
            public string url;

        }

        public class Color
        {
            public string name;
            public string value;
        }

        public class Category
        {
            public string name;
        }

        public class Size
        {
            public string name;
            public string value;
        }

        public class StoreImage
        {
            public string Id { get; set; }
            public string StoreId { get; set; }
            public string Label { get; set; }
            public string ImageUrl { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
        }

        static void Main(string[] args)
        {
            using var client = new HttpClient();
            var endpoint = new Uri("http://localhost:3000/api/9f706ecd-6d66-45c7-a165-93e8c9f97750/categories");
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            List<Content>? items = JsonConvert.DeserializeObject<List<Content>>(json);

            foreach (var item in items)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Store ID: {item.storeId}");
                Console.WriteLine($"Billboard ID: {item.billboardId}");
                Console.WriteLine($"Name: {item.name}");
                Console.WriteLine($"Created At: {item.createdAt}");
                Console.WriteLine($"Updated At: {item.updatedAt}");
            }

            Console.WriteLine("\n \n \n \n \n");
            using var client3 = new HttpClient();
            var endpoint3 = new Uri("http://localhost:3000/api/9f706ecd-6d66-45c7-a165-93e8c9f97750/products");
            var result3 = client3.GetAsync(endpoint3).Result;
            var json3 = result3.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(json2 + "\n \n \n \n ");
            List<Product>? items3 = JsonConvert.DeserializeObject<List<Product>>(json3);
            foreach (var item in items3)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Image: {item.Images[0].url}");
                Console.WriteLine($"Color: {item.Color.name}");
                Console.WriteLine($"ColorRGB: {item.Color.value}");
                Console.WriteLine($"Category: {item.Category.name}");
                Console.WriteLine($"Size: {item.Size.name}");
            }

            using var client2 = new HttpClient();
            var endpoint2 = new Uri("http://localhost:3000/api/9f706ecd-6d66-45c7-a165-93e8c9f97750/billboards");
            var result2 = client2.GetAsync(endpoint2).Result;
            var json2 = result2.Content.ReadAsStringAsync().Result;
            List<StoreImage>? items2 = JsonConvert.DeserializeObject<List<StoreImage>>(json2);
            foreach(var item in items2)
            {
                Console.WriteLine(item.ImageUrl);
            }
        }

        
        
    }
}
