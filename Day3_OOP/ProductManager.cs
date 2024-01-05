using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_OOP;

public class ProductManager
{
  private List<Product> products;


    public ProductManager()
    {
        products = new List<Product>()
        {
            new Product{Name="Apple Telefon",Price=55000,Stock=250},
            new Product{Name="Samsung Telefon", Price=25000,Stock=125}
        };
    }

    public void Add(Product product)
    {
        products.Add(product);
    }
    public void Remove(string name)
    {
        // 1. Yöntem
        //foreach (Product product in products) 
        //{
        //    if (product.Name==name)
        //    {
        //        products.Remove(product);
        //        break;
        //    }
        //}

      Product? product=products.FirstOrDefault(x=> x.Name ==name);
      products.Remove(product);
    }

    public void GetAll()
    {
        products.ForEach(x=> Console.WriteLine(x));
    }

    public void GetStockRange(int min, int max)
    {
        //1.Yöntem
        //foreach(Product product in products)
        //{
        //    if(product.Stock < max && product.Stock > min)
        //    {
        //        Console.WriteLine(product);
        //    }
        //}

        List<Product> filteredProducts = products
            .Where(x=>x.Stock>min && x.Stock<max).ToList();

        filteredProducts.ForEach(x => Console.WriteLine(x));


    }

    public void GetPriceRange(double min, double max)
    {
        // 1. Yöntem 
        //foreach (Product product in products)
        //{
        //    if (product.Price < max && product.Price > min)
        //    {
        //        Console.WriteLine(product);
        //    }
        //}

        List<Product> filteredProducts =
            products.Where(p => p.Price > min && p.Price < max).ToList();
        filteredProducts.ForEach(x => Console.WriteLine(x));



    }
    public void GetByName(string name)
    {
        List<Product> filter = products.Where(x=>x.Name.Contains(name))
            .ToList();

        filter.ForEach(x => Console.WriteLine(x));  
    }

}
