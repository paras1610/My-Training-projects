Category c1=new Category();
c1.CategoryName = "ice cream";
c1.CategoryId=321;





Product p1 = new Product();
p1.Name = "Faluda";
p1.ProductId = 123;
p1.Thecategory = c1;


Product p2 = new Product();
p2.Name = "butterscotch";
p2.ProductId = 234;
p2.Thecategory = c1;
c1.products.Add(p1);
c1.products.Add(p2);
//foreach c1.products in Category 
Console.WriteLine($"the name of product is {c1.CategoryName} and its products are {c1.products.Count}");
foreach (Product product in c1.products) { Console.WriteLine(product.Name); }

class Product
{  public string Name { get; set; }
   public int ProductId { get; set; }
    public Category Thecategory { get; set; }
}
class Category
{
    public string CategoryName { get; set; }
    public int CategoryId { get; set; }
    public List<Product> products=new List<Product>();
}


