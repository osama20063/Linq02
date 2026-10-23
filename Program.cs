namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion


            #region Question 2
            //var result = ProductList.Skip(5).Take(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion


            #region Question 3
            //var result = ProductList.TakeWhile(p => p.UnitPrice < 25);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion


            #region Question 4
            //bool result = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);
            #endregion

            #region Question 5
            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);

            //Console.WriteLine(result);
            #endregion



            #region Question 6
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Count: {item.Count}");
            //}
            #endregion



            #region Question 7
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Select(g => new { Category = g.Key, Products = g.Select(p => p.ProductName) });

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var name in group.Products)
            //    {
            //        Console.WriteLine($"  - {name}");
            //    }
            //}
            #endregion

            #region Question 8
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Where(g => g.Count() > 3)
            //                       .Select(g => g.Key);

            //foreach (var category in result)
            //{
            //    Console.WriteLine($"Category: {category}");
            //}
            #endregion



            #region Question 9
            //var result = from c in CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Country: {item.Country}, Count: {item.Count}, TotalOrderValue: {item.TotalOrderValue}");
            //}
            #endregion


            #region Question 10
            //var result = ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total Units in Stock: {result}");
            #endregion


            #region Question 11
            //var minPrice = ProductList.Min(p => p.UnitPrice);
            //var maxPrice = ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest Price: {minPrice}");
            //Console.WriteLine($"Most Expensive Price: {maxPrice}");
            #endregion


            #region Question 12
            //var result = ProductList.Select(p => p.Category).Distinct();

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion


            #region Question 13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var id in result)
            //{
            //    Console.WriteLine(id);
            //}
            #endregion


            #region Question 14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}
            #endregion

            #region Question 15
            //var dictionary = ProductList.ToDictionary(p => p.ProductID);

            //if (dictionary.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("Product with ID 18 not found.");
            //}
            #endregion

            #region Question 16
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 50);

            //if (result != null)
            //{
            //    Console.WriteLine($"Name: {result.ProductName}, Price: {result.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found.");
            //}
            #endregion


            #region Question 17
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);

            //if (result == null)
            //{
            //    Console.WriteLine("null");
            //}
            //else
            //{
            //    Console.WriteLine($"Name: {result.ProductName}, Price: {result.UnitPrice}");
            //}
            #endregion


            #region Question 18
            //var result = Enumerable.Range(1, 10).Select(i => new { Number = i, Multiple = i * 7 });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"7 * {item.Number} = {item.Multiple}");
            //}
            #endregion

            #region Question 19
            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

        }
    }
}
