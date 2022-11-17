namespace ProductCatalog.UI
{
    internal class Progam
    {
        static void Main(string[] args)
        { 
          // add new category and new product with two products
          category c = new category{ namespace="smart watch"};
          product p1= new product { namespace="iwatch.Price=67000",Brand="apple"};
          product p2 =new product { namespace="galaxy gear".Price=70000,Brand="samsung"};
          c.products.add(p1);
          c.products.ad(p2);

        }           
    }
}
