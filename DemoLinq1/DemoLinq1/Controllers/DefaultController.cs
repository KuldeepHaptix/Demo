using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoLinq1.Models;

namespace DemoLinq1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        NorthwindEntities entities = new NorthwindEntities();
        public ActionResult Index()
        {
            linq();
            return View();
        }

        public void linq()
        {
            //List<Product> products = new List<Product>();
            // products = entities.Products.ToList();

            //var soldout = from p in products where p.UnitsInStock == 0 select p;
            //Response.Write("Sold out Products");
            //foreach (var product in soldout)
            //{
            //    Response.Write("Sold out Products" + product.ProductName);

            //}
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //var expensiveInStockProducts =
            //from p in products
            //where p.UnitsInStock > 0 && p.UnitPrice > 3.00M
            //select p;
            //Response.Write("In-stock products that cost more than 3.00:");
            //foreach (var product in expensiveInStockProducts)
            //{
            //    Response.Write("{0} is in stock and costs more than 3.00."+ product.ProductName);
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            // List<Customer> customers = new List<Customer>();
            // customers = entities.Customers.ToList();
            //var waCustomers =
            //from c in customers
            //where c.Region == "WA"
            //select c;

            //Response.Write("Customers from Washington and their orders:");
            //foreach (var customer in waCustomers)
            //{
            //    Response.Write("Customer {0}: {1}" + customer.CustomerID + customer.CompanyName);
            //    foreach (var order in customer.Orders)
            //    {
            //        Response.Write("  Order {0}: {1}"+ order.OrderID + order.OrderDate);
            //    }
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numberGroups =
            //    from n in numbers
            //    group n by n % 5 into g
            //    select new { Remainder = g.Key, Numbers = g };

            //foreach (var g in numberGroups)
            //{
            //    Response.Write("Numbers with a remainder of {0} when divided by 5:"+ g.Remainder);
            //    foreach (var n in g.Numbers)
            //    {
            //        Response.Write(n);
            //    }
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            //var wordGroups =
            //    from w in words
            //    group w by w[0] into g
            //    select new { FirstLetter = g.Key, Words = g };

            //foreach (var g in wordGroups)
            //{
            //    Response.Write("Words that start with the letter '{0}':"+ g.FirstLetter);
            //    foreach (var w in g.Words)
            //    {
            //        Response.Write(w);
            //    }
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //List<Category> categories = new List<Category>();
            //categories = entities.Categories.ToList();

            //string[] cate = new string[]{"Beverages",  "Condiments",  "Vegetables",  "Dairy Products", "Seafood" };

            //var q = from c in categories join p in products on c equals p.Category select new { Category = c , p.ProductName };

            //foreach (var v in q)
            //{
            //    Response.Write(v.ProductName + ": " + v.Category);
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var allNumbers = numbersA.Concat(numbersB);

            //Response.Write("All numbers from both arrays:");
            //foreach (var n in allNumbers)
            //{
            //    Response.Write(n);
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //List<Product> products = new List<Product>();
            //products = entities.Products.ToList();
            //List<Customer> customers = new List<Customer>();
            //customers = entities.Customers.ToList(); 

            //var customerNames = from c in customers select c.CompanyName;
            //var productNames = from p in products select p.ProductName;
            //var allNames = customerNames.Concat(productNames);

            //Response.Write("Customer and product names:");
            //foreach (var n in allNames)
            //{
            //    Response.Write(n);
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //var wordsA = new string[] { "cherry", "apple", "blueberry" };
            //var wordsB = new string[] { "cherry", "apple", "blueberry" };

            //bool match = wordsA.SequenceEqual(wordsB);
            //Response.Write("The sequences match: {0}"+ match);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //var wordsA = new string[] { "cherry", "apple", "blueberry" };
            //var wordsB = new string[] { "apple", "blueberry", "cherry" };

            //bool match = wordsA.SequenceEqual(wordsB);
            //Response.Write("The sequences match: {0}" + match);
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //var numbers =
            //from n in Enumerable.Range(100, 50)

            // select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            //foreach (var n in numbers)
            //{
            //    Response.Write("The number {0} is {1}." + "</br>"+ n.Number + n.OddEven);
            //}
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            //int uniqueFactors = factorsOf300.Distinct().Count();

            //Response.Write("There are {0} unique factors of 300."+ uniqueFactors);
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //  int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //  int oddNumbers = numbers.Count(n => n % 2 == 1);

            //Response.Write("There are {0} odd numbers in the list."+ oddNumbers);
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //double numSum = numbers.Sum();

            //Response.Write("The sum of the numbers is {0}."+ numSum);

            //Response.Write("There are {0} odd numbers in the list."+ oddNumbers);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //string[] words = { "cherry", "apple", "blueberry" };
            //double totalChars = words.Sum(w => w.Length);
            //Response.Write("There are a total of characters in these words."+ totalChars);
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //string[] words = { "cherry", "apple", "blueberry" };
            //int shortestWord = words.Min(w => w.Length);
            //Response.Write("The shortest word is {0} characters long." + shortestWord);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int maxNum = numbers.Max();
            //Response.Write("The maximum number is "+ maxNum);
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //string[] words = { "cherry", "apple", "blueberry" };
            //int longestLength = words.Max(w => w.Length);
            //Response.Write("The longest word is {0} characters long." + longestLength);
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //double averageNum = numbers.Average();
            //Response.Write("The average number is {0}." + averageNum);
            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //string[] words = { "cherry", "apple", "blueberry" };
            //double averageLength = words.Average(w => w.Length);
            //Response.Write("The average word length is characters." + averageLength);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            //double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);
            //Response.Write("Total product of all numbers: {0}" + product);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //double startBalance = 100.0;
            //int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };
            //double endBalance =
            //attemptedWithdrawals.Aggregate(startBalance, (balance, nextWithdrawal) => ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));
            //Response.Write("Ending balance: {0}" + endBalance);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            //var uniqueFactors = factorsOf300.Distinct();
            //Response.Write("Prime factors of 300:" + "</br>");
            //foreach (var f in uniqueFactors)
            //{
            //    Response.Write(f+"</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //List<Product> products = new List<Product>();
            //products = entities.Products.ToList();
            //List<Category> categories = new List<Category>();
            //categories = entities.Categories.ToList();


            //var CategoryNames = (from p in products select p.Category).Distinct();
            //Response.Write("Category names:" + "</br>");
            //foreach (var n in CategoryNames)
            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var uniqueNumbers = numbersA.Union(numbersB);

            //Response.Write("Unique numbers from both arrays:" + "</br>");
            //foreach (var n in uniqueNumbers)
            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            // List < Product > products = new List<Product>();
            // products = entities.Products.ToList();
            //List<Customer> customers = new List<Customer>();
            //customers = entities.Customers.ToList();

            //var productFirstChars = from p in products select p.ProductName[0];
            //var customerFirstChars = from c in customers select c.CompanyName[0];    
            //var uniqueFirstChars = productFirstChars.Union(customerFirstChars);

            //Response.Write("Unique first letters from Product names and Customer names:" + "</br>");
            //foreach (var ch in uniqueFirstChars)
            //{
            //    Response.Write(ch + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var commonNumbers = numbersA.Intersect(numbersB);

            //Response.Write("Common numbers shared by both arrays:" + "</br>");
            //foreach (var n in commonNumbers)
            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //List<Product> products = new List<Product>();
            //products = entities.Products.ToList();
            //List<Customer> customers = new List<Customer>();
            //customers = entities.Customers.ToList();

            //var productFirstChars = from p in products select p.ProductName[0];
            //var customerFirstChars = from c in customers select c.CompanyName[0];
            //var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

            //Response.Write("First letters from Product names, but not from Customer names:" + "</br>");
            //foreach (var ch in productOnlyFirstChars)
            //{
            //    Response.Write(ch + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            //var sortedDoubles = from d in doubles orderby d descending select d;
            //var doublesArray = sortedDoubles.ToArray();

            //Response.Write("Every other double from highest to lowest:" + "</br>");
            //for (int d = 0; d < doublesArray.Length; d += 2)
            //{
            //    Response.Write(doublesArray[d] + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            // string[] words = { "cherry", "apple", "blueberry" };
            //var sortedWords = from w in words orderby w select w;  
            //var wordList = sortedWords.ToList();
            //Response.Write("The sorted word list:" + "</br>");
            //foreach (var w in wordList)
            //{
            //    Response.Write(w + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //var scoreRecords = new[] { new { Name = "Alice", Score = 50 }, new { Name = "Bob", Score = 40 }, new { Name = "Cathy", Score = 45 } };

            //var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

            //Response.Write("Bob's score: {0}"+"</br>"+ scoreRecordsDict["Bob"]);


            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

            //var doubles = numbers.OfType<double>();

            //Response.Write("Numbers stored as doubles:" + "</br>");
            //foreach (var d in doubles)
            //{
            //    Response.Write(d + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //string[] words = { "believe", "relief", "receipt", "field" };
            //bool iAfterE = words.Any(w => w.Contains("ei"));
            //Response.Write("There is a word that contains in the list that contains 'ei': {0}" + iAfterE);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
            //bool onlyOdd = numbers.All(n => n % 2 == 1);
            //Response.Write("The list contains only odd numbers: {0}" + onlyOdd);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //string[] words = { "believe", "relief", "receipt", "field" };
            //bool iAfterE = words.Any(w => w.Contains("ei"));
            //Response.Write("There is a word that contains in the list that contains 'ei': {0}" + iAfterE);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
            //bool onlyOdd = numbers.All(n => n % 2 == 1);
            //Response.Write("The list contains only odd numbers: {0}"+ onlyOdd);

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int i = 0;
            //var q = from n in numbers select ++i;

            //foreach (var v in q)
            //{
            //    Response.Write("v = {0}, i = {1}"+"</br>"+ v + i);
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int i = 0;
            //var q = (from n in numbers select ++i).ToList();
            //foreach (var v in q)
            //{
            //    Response.Write("v , i "+"</br>"+ v + i);
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var lowNumbers = from n in numbers where n <= 3 select n;
            //Response.Write("First run numbers <= 3:");

            //foreach (int n in lowNumbers)
            //{
            //    Response.Write(n + "</br>");
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    numbers[i] = -numbers[i];
            //}
            //Response.Write("Second run numbers <= 3:");

            //foreach (int n in lowNumbers)
            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            // string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            // var upperLowerWords = from w in words select new { Upper = w.ToUpper(), Lower = w.ToLower() };    

            //foreach (var ul in upperLowerWords)
            // {
            //      Response.Write("Uppercase: Lowercase:"+"</br>"+ ul.Upper + ul.Lower);      
            // }


            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //List<Product> products = new List<Product>();
            //products = entities.Products.ToList();

            //var productInfos = from p in products select new { p.ProductName, p.Category, Price = p.UnitPrice };
            //Response.Write("Product Info:"+"</br>");
            //foreach (var productInfo in productInfos)
            //{
            //    Response.Write("{0} is in the category {1} and costs {2} per unit." + productInfo.ProductName + productInfo.Category + productInfo.Price);
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });

            //Response.Write("Number: In-place?" +"</br>");
            // foreach (var n in numsInPlace)
            // {
            //    Response.Write("{0}: {1}" + "</br>" + n.Num + n.InPlace);
            // }


            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var lowNums = from n in numbers where n < 5 select digits[n];
            //Response.Write("Numbers < 5:"+"</br>");
            //foreach (var num in lowNums)
            //{
            //    Response.Write(num + "</br>");
            //}


            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            // int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            // int[] numbersB = { 1, 3, 5, 7, 8 };

            // var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
            //Response.Write("Pairs where a < b:"+"</br>");
            // foreach (var pair in pairs)
            // {
            //    Response.Write("{0} is less than {1}" + "</br>" + pair.a + pair.b);
            // }

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var first3Numbers = numbers.Take(5);
            //Response.Write("First 3 numbers:"+"</br>");

            //foreach (var n in first3Numbers)
            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var allButFirst4Numbers = numbers.Skip(4);
            //Response.Write("All but first 4 numbers:" + "</br>");

            //foreach (var n in allButFirst4Numbers)
            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 5, 4, 1, 3, 0, 8, 6, 7, 2, 9 };
            //var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 7);
            //Response.Write("First numbers less than 6:" + "</br>");

            //foreach (var n in firstNumbersLessThan6)

            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
            //Response.Write("First numbers not less than their position:" + "</br>");

            //foreach (var n in firstSmallNumbers)
            //{ 
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);
            //Response.Write("All elements starting from first element divisible by 3:" + "</br>");
            //foreach (var n in allButFirst3Numbers)
            //{
            //    Response.Write(n + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var laterNumbers = numbers.SkipWhile((n, index) => n >= index);
            //Response.Write("All elements starting from first element less than its position:" + "</br>");
            //foreach (var n in laterNumbers)

            //{
            //    Response.Write(n + "</br>");
            //}


            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //string[] words = { "cherry", "apple", "blueberry" };
            //var sortedWords = from w in words orderby w select w;
            //Response.Write("The sorted list of words:" + "</br>");
            //foreach (var w in sortedWords)
            //{
            //    Response.Write(w + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //string[] words = { "cherry", "apple", "blueberry" };
            //var sortedWords = from w in words orderby w.Length select w;
            //Response.Write("The sorted list of words (by length):" + "</br>");
            //foreach (var w in sortedWords)
            //{
            //    Response.Write(w + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            //var sortedDoubles = from d in doubles orderby d descending select d;
            //Response.Write("The doubles from highest to lowest:" + "</br>");
            //foreach (var d in sortedDoubles)
            //{
            //    Response.Write(d + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var sortedDigits = from d in digits orderby d.Length, d select d;
            //Response.Write("Sorted digits:" + "</br>");
            //foreach (var d in sortedDigits)
            //{
            //    Response.Write(d + "</br>");
            //}

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var reversedIDigits = (from d in digits where d[1] == 'i' select d).Reverse();
            Response.Write("A backwards list of the digits with a second character of 'i':" + "</br>");
            foreach (var d in reversedIDigits)
            {
                Response.Write(d + "</br>");
            }

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-//

        }
    }
}