using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryReview
{
    internal class Program
    {
        // static Dictionary<string, int> ages = new Dictionary<string, int>();
        // create a dictionary of products
        static Dictionary<int, Product> products = new Dictionary<int, Product>();
        static ShoppingCart cart = new ShoppingCart();
        static void Main(string[] args)
        {
            /*
            ages.Add("John", 25);
            ages.Add("Jane", 30);
            ages.Add("Bob", 35);

            PrintDict();

            ages = Remove("Jane");

            PrintDict();

            Console.ReadLine();
            

            // counting characters in a string

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts.Add(c,1);
                }
            }
            // display the results
            foreach (var kvp in counts)
            { 
                Console.WriteLine(kvp.Key + "--" + kvp.Value);
            }

            // counting words in a string
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            var listWords = sentence.Split(new char[] { ' ', '.', ',', '!', '?' });

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (var word in listWords)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else if (word != string.Empty)
                {
                    wordCounts.Add(word, 1);
                }
            }

            foreach (var kvp in wordCounts)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }
*/
            // next example, online shoping cart
            // our inventory
            var product1 = new Product(1, "Laptop", 1000, 10);
            products.Add(1, product1);

            var product2 = new Product(2, "Phone", 500, 20);
            products.Add(2, product2);

            var product3 = new Product(3, "Tablet", 300, 15);
            products.Add(3, product3);

            //create a shopping cart
            var cart = new ShoppingCart();

            // shoppwer adds products to the cart
            cart.AddProduct(1);
            cart.AddProduct(2);
            cart.AddProduct(3);

            // remove a product from the cart
            cart.RemoveProduct(2);

            // display the cart
            cart.DisplayCart();
            // calculate the total price
            Console.WriteLine("Total price: " + cart.CalPrice());

            cart.Checkout();

            // display the inventory
            foreach (var kvp in products)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value.Name + ":" + kvp.Value.Stock);
            }
        }

        class ShoppingCart
        {
            public ShoppingCart()
            {
                productsList = new List<Product>();
            }
            public List<Product> productsList { get; set; }
            public void AddProduct(int anId)
            {
                productsList.Add(anId);
            }
            public double CalPrice()
            { 
                double sum = 0;
                foreach (var id in productsList)
                {
                    sum += products[id].Price;
                }
                return sum;
            }
            public void DisplayCart()
            {
                foreach (var id in productsList)
                {
                    products[id].Display();
                }
            }

            public void Checkout()
            {
                foreach (var id in productsList)
                {
                    products[id].Stock-= 1;
                }
                // remove the products from the cart
                productsList.Clear();
            }
            public void RemoveProduct(int anId)
            {
                productsList.Remove(anId);
            }
        }

        // define a Product class
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public Product(int id,string name, double price,int stock)
            {
                Id = id;
                Name = name;
                Price = price;
                Stock = stock;
            }
            public void Display()
            { 
                Console.WriteLine($"Id: {Id}, Name: {Name}, Price: {Price}, Stock: {Stock}");
            }
        }
        /*
                static void Add(string aName, int anAge)
                {
                    ages.Add(aName, anAge);
                }
                static Dictionary<string, int> Remove(string aName)
                {
                    var newDict = new Dictionary<string, int>();
                    foreach (var a in ages)
                    {
                        if (a.Key != aName) 
                        {
                            newDict.Add(a.Key, a.Value);
                        }
                    }
                    return newDict;
                }
                static void PrintDict()
                {
                    foreach (var a in ages)
                    {
                        Console.WriteLine(a.Key + " " + a.Value);
                    }
                }
        */
    }
}
