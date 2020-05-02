using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrmApp
{
  public class Basket
  {
    private List<Product> Products { get; set; }

    public Customer Customer { get; set; }


    public Basket()
    {
      Products = new List<Product>();
    }



    public void AddProduct(Product product)
    {
      Products.Add(product);
    }


    public decimal TotalCost()
    {
      decimal totalCost = 0;
      foreach (Product p in Products)
      {
        totalCost += p.TotalCost;
      }
      return totalCost;
    }


    public void Print()
    {
      foreach (Product p in Products)
      {
        Console.WriteLine(p);

      }
    }

    public void ShowCategories()
    {
      int howManyLow = 0;
      int howManyMedium = 0;
      int howManyHi = 0;
      foreach (Product p in Products)
      {
        if (p.GetRange() == "low") howManyLow++;
        if (p.GetRange() == "medium") howManyMedium++;
        if (p.GetRange() == "hi") howManyHi++;

      }
      Console.WriteLine($"howManyLow= {howManyLow}");
      Console.WriteLine($"howManyMedium= {howManyMedium}");
      Console.WriteLine($"howManyHi= {howManyHi}");
    }

    public string Save(string filename)
    {
      try
      {
        StreamWriter sw = new StreamWriter(filename, true);

        foreach (Product product in Products)
        {
          sw.WriteLine(product.Name + "," +
                       product.Price + "," +
                       product.Quantity);
        }
        sw.Close();
      }
      catch (Exception e)
      {
        return "Error" + e.Message;
      }
      return "Data Saved!";
    }


    public string Load(string filename)
    {
      try
      {
        Products.Clear();
        StreamReader sr = new StreamReader(filename);
        string line;

        line = sr.ReadLine();

        while (line != null)
        {

          string[] words = line.Split(",");
          Product product = new Product
          {
            Name = words[0],
            Price = decimal.Parse(words[1]),
            Quantity = int.Parse(words[2])
          };
          Products.Add(product);
          line = sr.ReadLine();
        }
       }
      catch (Exception e)
      {
        return "Error!";
      }
        return "success!";
  }
 }
}

