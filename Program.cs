

Product product1 = new Product();
product1.ProductType = "Television";
product1.ProductBrand = "Samsung";
product1.Price = 800;

Product product2 = new Product();
product2.ProductType = "Bluetooth Headset";
product2.ProductBrand = "Beats";
product2.Price = 250;

Product product3 = new Product();
product3.ProductType = "Game Console";
product3.ProductBrand = "Sony";
product3.Price = 600;

Product product4 = new Product();
product4.ProductType = "Computer";
product4.ProductBrand = "Apple";
product4.Price = 2000;



String[] products2 = new string[] {product1.ProductBrand, product2.ProductBrand,
    product3.ProductBrand, product4.ProductBrand};


for (int i = 0; i < products2.Length; i++){
    Console.WriteLine(products2[i]);
}

Console.WriteLine("-----FOR DÖNGÜSÜ BİTTİ-----");

Product[] products = new Product[] { product1, product2, product3, product4 };
foreach (var getproducts in products)
{
    Console.WriteLine(getproducts.ProductBrand + " , "+getproducts.ProductType 
        + " , " + getproducts.Price);
}

Console.WriteLine("-----FOREACH DÖNGÜSÜ BİTTİ-----");

{

int i = 0;

    while (i < products2.Length)
    {

        Console.WriteLine(products2[i]);
        i++;
        
        
    }
}

Console.WriteLine("-----WHILE DÖNGÜSÜ BİTTİ-----");






class Product
{
    public string ProductType { get; set; }
    public string ProductBrand { get; set; }
    public int Price { get; set; }
}
