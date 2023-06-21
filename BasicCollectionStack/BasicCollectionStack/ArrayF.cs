using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCollections
{
    public class ArrayF
    {
        //2D
        public static void Array2D()
        {
            int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine($"This value is {array2D[1, 1]}");
        }

        public static void Array3D()
        {
            string[,,] array3D =
            {
                //Depth
                {
                    //Height
                    {"Rhat", "Kazol","Moinul", "Rajit" }, //Length
                    {"Rhat", "Kazol","Moinul", "Rajit" },
                    {"Rhat", "Kazol","Moinul", "Rajit" }

                },

                {
                    //Height
                    {"Rhat", "Kazol","Moinul", "Rajit" }, //Length
                    {"Rhat", "Kazol","Poly", "Rajit" },
                    {"Rhat", "Adil","Fariha", "Labeeb" }

                },


            };

            Console.WriteLine(array3D.Rank);
            Console.WriteLine($"This value is {array3D[1, 2, 3]}");
        }

        public static void jaggedArray()
        {
            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[6];
            jaggedArray[3] = new int[7];

            jaggedArray[0] = new int[] { 0, 4, 5, 2, 3 };
            jaggedArray[1] = new int[] { 0, 4, 5, 2, 3 };
            jaggedArray[2] = new int[] { 0, 4, 5, 2, 3 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[]{0,4},
                new int[] {0,5,6,7},
                new int[]{0,8,9,7}
            };

            Console.WriteLine($"The value is {0}", jaggedArray[0][4]);

            Console.WriteLine("This", "is", "a bad", "example");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("Element {0}, ", jaggedArray[i][j]);

                }
;
            }
        }

        public static void ArrayParamsKey(params object[] sentence)
        {
            // for(int i=0;i<sentence.Length;i++)
            // {
            //     Console.Write(sentence[i], " ");
            //}

            foreach (var item in sentence)
            {
                Console.WriteLine(item + " ");
            }
        }

        public static void GenericAndNonGeneric()
        {
            /* int num1 = 3;
             string myName = "R";
             float myNum2 = 45.4f;
             ArrayList myArrayList = new ArrayList();

             myArrayList.Add(myName);
             myArrayList.Add(num1);
             myArrayList.Add(myNum2);

             foreach(var item in myArrayList)
             {
                 if(item is int)
                 {
                     Console.WriteLine("ArrayList doses constain integer {0}", item);
                 }
             }

             myArrayList.Remove("R");
             myArrayList.RemoveAt(0);

             foreach (var item in myArrayList)
             {

                     Console.WriteLine("ArrayList doses constain integer {0}", item);

             }*/

            //Generic List
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);

            foreach (int item in list)
            {
                Console.WriteLine("List item {0}", item);
            }


        }

        public static void HashTableF()
        {
            Hashtable productTable = new Hashtable();
            /*Product product1 = new Product(1, "Eggs", 2.95);
            Product product2 = new Product(2, "Apple", 1.95);
            Product product3 = new Product(3, "Mango", 3.95);
            Product product4 = new Product(4, "Bread", 4.95);
            Product product5 = new Product(5, "Rice", 1.95);

            productTable.Add(product1.Id, product1);
            productTable.Add(product2.Id, product2);
            productTable.Add(product3.Id, product3);
            productTable.Add(product4.Id, product4);
            productTable.Add(product5.Id, product5);

            //Individual item
            Product storeProduct1 = (Product)productTable[product1.Id];
            Console.WriteLine($"Product ID {storeProduct1.Id}, Product Name: {storeProduct1.ProductName}, Price: {storeProduct1.Price}");

            foreach(DictionaryEntry item in productTable)
            {
                Product temp = (Product)item.Value;
                Console.WriteLine("Product ID {0}", temp.Id);
                Console.WriteLine("Product Name {0}", temp.ProductName);
                Console.WriteLine("Product Price {0}", temp.Price);
            }*/

            /*Product[] products = new Product[5];

            Product product1 = new Product(1, "Eggs", 2.95);
            Product product2 = new Product(2, "Apple", 1.95);
            Product product3 = new Product(3, "Mango", 3.95);
            Product product4 = new Product(4, "Bread", 4.95);
            Product product5 = new Product(5, "Rice", 1.95);

            //Validation
            foreach(Product product in products)
            {
                if(!productTable.ContainsKey(product.Id))
                {
                    productTable.Add(product.Id, product);

                }
                else
                {
                    Console.WriteLine("The product {0} is already exists", product.Id);
                }
            }

            foreach (DictionaryEntry item in productTable.Values)
            {
                Product temp = (Product)item.Value;
                Console.WriteLine("Product ID {0}", temp.Id);
                Console.WriteLine("Product Name {0}", temp.ProductName);
                Console.WriteLine("Product Price {0}", temp.Price);
            }*/

        }

        public static void DictonaryF()
        {
            /*Invoice[] invoices = {
               new Invoice("Eggs", 4, "a@gmail.com", 400),
            new Invoice("Rice", 4, "j@gmail.com", 800),
            new Invoice("Mango", 6, "k@gmail.com", 700),
            new Invoice("Apple", 9, "l@gmail.com", 500),
            new Invoice("Milk", 10, "m@gmail.com", 900),

            };

            Dictionary<string, Invoice> myInvoices = new Dictionary<string, Invoice>();

            foreach (Invoice item in invoices)
            {
                myInvoices.Add(item.ProductName, item);
            }*/

            //Filter/Search
            /* string Key = "Eggs";
             if(myInvoices.ContainsKey(Key))
             {
                 Invoice ownInvoices = myInvoices[Key];
                 Console.WriteLine($"Product Found {ownInvoices.ProductName}");
             }
             else
             {
                 Console.WriteLine("No product found with this key {0}", Key);
             }*/

            /* Invoice result = new Invoice();
             string Key = "Rice";
             if (myInvoices.TryGetValue(Key, out result))
             {
                 Invoice ownInvoices = myInvoices[Key];
                 Console.WriteLine($"Product Found {ownInvoices.ProductName}");
             }
             else
             {
                 Console.WriteLine("No product found with this key {0}", Key);
             }*/

            /*foreach(Invoice item in myInvoices.Values)
            {
                Console.WriteLine($"Product -> : {item.ProductName}");
            }

            //Update

            string keyToUpdate = "Milk";

            if(myInvoices.ContainsKey(keyToUpdate))
            {
                myInvoices[keyToUpdate] = new Invoice("Beef", 4, "h@gmail.com", 400);
                Console.WriteLine("Product is updated:{0}", keyToUpdate);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            foreach (Invoice item in myInvoices.Values)
            {
                Console.WriteLine($"Product -> : {item.ProductName}");
            }

            //Delete
            string keyToRemove = "Beef";

            if (myInvoices.Remove(keyToUpdate))
            {
                myInvoices[keyToUpdate] = new Invoice("Beef", 4, "h@gmail.com", 400);
                Console.WriteLine("Product is updated:{0}", keyToUpdate);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            foreach (Invoice item in myInvoices.Values)
            {
                Console.WriteLine($"Product -> : {item.ProductName}");
            }*/



        }

        public static void StackF()
        {
            //push pop peak

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Stack<int> myReverseNumber = new Stack<int>();

            foreach (var item in numbers)
            {
                Console.WriteLine(item + " ");
                myReverseNumber.Push(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("---------");
            Console.WriteLine("The numbers is reverse:");

            while (myReverseNumber.Count > 0)
            {
                int myNumbers = myReverseNumber.Pop();
                Console.WriteLine(myNumbers + " ");
            }
        }



    }
}