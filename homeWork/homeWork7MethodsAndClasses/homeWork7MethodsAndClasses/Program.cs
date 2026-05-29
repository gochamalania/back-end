namespace homeWork7MethodsAndClasses;


#region task1

// 1. შექმენით Product კლასი//
// კლასში უნდა იყოს მინიმუმ 10 მახასიათებელი (Property/Field). მაგალითად://
//     · Id//
//     · Name//
//     · Description//
//     · Price//
//     · Quantity//
//     · Brand//
//     · Category//
//     · Rating//
//     · IsAvailable//
//     · DiscountPercent//
//     შეგიძლიათ დაამატოთ სხვა მახასიათებლებიც.

// class Product
// {
//
//     public int Id;
//     public string Name;
//     public string Description;
//     public decimal Price;
//     public int Quantity;
//     public string Brand;
//     public string Category;
//     public double Rating;
//     public bool IsAvailable;
//     public decimal DiscountPercent;
//
//     public string Color;
//     public double Weight;
//     public string Country;
// }

#endregion

#region task2

// 2. შექმენით მინიმუმ 3 მეთოდი//
//     მაგალითად://
// · საბოლოო ფასის გამოთვლა ფასდაკლებით//
// · პროდუქტის მარაგის გაზრდა//
// · პროდუქტის ინფორმაციის დაბეჭდვა//
//     ან სხვა ლოგიკური მეთოდები.

// class Product
// {
//     public int Id;
//     public string Name;
//     public string Description;
//     public decimal Price;
//     public int Quantity;
//     public string Brand;
//     public string Category;
//     public double Rating;
//     public bool IsAvailable;
//     public decimal DiscountPercent;
//
//     public string Color;
//     public double Weight;
//     public string Country;
//
//     public decimal GetFinalPrice()
//     {
//         decimal discountAmount = Price * DiscountPercent / 100;
//         return Price - discountAmount;
//     }
//
//     public void AddStock(int amount)
//     {
//         if (amount > 0)
//         {
//             Quantity += amount;
//             Console.WriteLine($"{amount} items added");
//         }
//         else
//         {
//             Console.WriteLine("Invalid amount");
//         }
//     }
//
//     public void PrintInfo()
//     {
//         Console.WriteLine($"Id: {Id}");
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Price: {Price} GEL");
//         Console.WriteLine($"Discount: {DiscountPercent}%");
//         Console.WriteLine($"Final Price: {GetFinalPrice()} GEL");
//         Console.WriteLine($"Quantity: {Quantity}");
//         Console.WriteLine($"Brand: {Brand}");
//         Console.WriteLine($"Category: {Category}");
//         Console.WriteLine($"Rating: {Rating}");
//         Console.WriteLine($"Available: {IsAvailable}");
//     }
//     
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Product phone = new Product();
//
//         phone.Id = 1;
//         phone.Name = "iPhone 15";
//         phone.Price = 3000m;
//         phone.DiscountPercent = 10;
//         phone.Quantity = 5;
//         phone.Brand = "Apple";
//         phone.Category = "Smartphone";
//         phone.Rating = 4.9;
//         phone.IsAvailable = true;
//
//         phone.PrintInfo();
//
//         phone.AddStock(3);
//
//         Console.WriteLine($"Updated Quantity: {phone.Quantity}");
//     }
// }

#endregion

#region task3

// 3. შექმენით კლასის ინსტანსი (ობიექტი)
// Main მეთოდში შექმენით Product კლასის ობიექტი და შეავსეთ მნიშვნელობები.
// მაგალითად:
// Product product1 = new Product();

// class Product
// {
//     public int Id;
//     public string Name;
//     public decimal Price;
//     public int Quantity;
//     public string Brand;
//
//     public void PrintInfo()
//     {
//         Console.WriteLine($"Id: {Id}");
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Price: {Price}");
//         Console.WriteLine($"Quantity: {Quantity}");
//         Console.WriteLine($"Brand: {Brand}");
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Product product1 = new Product();
//
//         product1.Id = 1;
//         product1.Name = "iPhone 15";
//         product1.Price = 3000m;
//         product1.Quantity = 5;
//         product1.Brand = "Apple";
//
//         product1.PrintInfo();
//     }
// }

#endregion

#region task4

// 4. გამოიძახეთ მეთოდები
//
// დაბეჭდეთ შედეგები Console.WriteLine()-ის გამოყენებით.
//
// ---
//
// დამატებითი პირობები
//
// · გამოიყენეთ class
//
//     · გამოიყენეთ properties
//
//     · გამოიყენეთ methods
//
//     · კოდი უნდა იყოს სუფთა და წაკითხვადი
//
//     · სურვილის შემთხვევაში გამოიყენეთ constructor
//
// ---
//
//     დამატებით სურვილისამებრ (არასავალდებულო)
//
// დაამატეთ:
//
//     · ფასდაკლების სისტემა
//
//     · პროდუქტის კატეგორიები
//
//     · მარაგის შემოწმება
//
//     · მომხმარებლის მიერ შეფასება (Rating)
//
//         ---
//
//     მაგალითი შედეგი კონსოლში
//
// პროდუქტი: Laptop ფასი: 2500₾ ფასდაკლება: 10% საბოლოო ფასი: 2250₾ მარაგშია: True

// class Product
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Description { get; set; }
//     public decimal Price { get; set; }
//     public int Quantity { get; set; }
//     public string Brand { get; set; }
//     public string Category { get; set; }
//     public double Rating { get; set; }
//     public bool IsAvailable { get; set; }
//     public decimal DiscountPercent { get; set; }
//
//
//     public Product(
//         int id,
//         string name,
//         string description,
//         decimal price,
//         int quantity,
//         string brand,
//         string category,
//         double rating,
//         bool isAvailable,
//         decimal discountPercent)
//     {
//         Id = id;
//         Name = name;
//         Description = description;
//         Price = price;
//         Quantity = quantity;
//         Brand = brand;
//         Category = category;
//         Rating = rating;
//         IsAvailable = isAvailable;
//         DiscountPercent = discountPercent;
//     }
//
//     public decimal GetFinalPrice()
//     {
//         decimal discountAmount = Price * DiscountPercent / 100;
//         return Price - discountAmount;
//     }
//
//     public void AddStock(int amount)
//     {
//         if (amount > 0)
//         {
//             Quantity += amount;
//         }
//     }
//
//     public bool CheckStock()
//     {
//         return Quantity > 0;
//     }
//
//     public void PrintInfo()
//     {
//         Console.WriteLine($"Product: {Name}");
//         Console.WriteLine($"Description: {Description}");
//         Console.WriteLine($"Brand: {Brand}");
//         Console.WriteLine($"Category: {Category}");
//         Console.WriteLine($"Price: {Price}₾");
//         Console.WriteLine($"Discount: {DiscountPercent}%");
//         Console.WriteLine($"Final Price: {GetFinalPrice()}₾");
//         Console.WriteLine($"Quantity: {Quantity}");
//         Console.WriteLine($"Rating: {Rating}");
//         Console.WriteLine($"In Stock: {CheckStock()}");
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Product product1 = new Product(
//             1,
//             "Laptop",
//             "Gaming Laptop",
//             2500m,
//             5,
//             "Asus",
//             "Electronics",
//             4.8,
//             true,
//             10
//         );
//
//         product1.PrintInfo();
//
//         Console.WriteLine();
//
//         product1.AddStock(3);
//
//         Console.WriteLine("After adding stock:");
//         Console.WriteLine($"Updated Quantity: {product1.Quantity}");
//     }
// }

#endregion