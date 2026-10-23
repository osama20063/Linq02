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
        }
    }
}
