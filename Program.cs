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

        }
    }
}
