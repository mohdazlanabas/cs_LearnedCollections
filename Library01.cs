namespace LearnedCollections
{
    public static class Library01
    {

        public static void Hello()
        {
            WriteLine("Hello, World!");
        }

        static void Exercise01()
        {
            // Collections
            List<String> customers = new List<String>(); // instantiate
            customers.Add("Mohd");
            customers.Add("Azlan");
            customers.Add("Abas");

            WriteLine(customers.Count);
            WriteLine(customers[1]);
            foreach (var customer in customers)
            {
                WriteLine(customer);
            }
        }

        static void Exercise02()
        {
            // Dictionaries
            Dictionary<String, String> config = new Dictionary<String, String>();
            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");
            // WriteLine(config["title"]);
            foreach (var setting in config)
            {
                WriteLine(setting.Value);
            }
        }

        static void Exercise03()
        {
            int i = 123;
            object o = i; // Boxing
            i = (int)o; // Casting
        }


        // CONCURRENCY
        static void Exercise04()
        {
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));
            thread1.Start();
            thread2.Start();
        }

        static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int, int>();
        static void AddItem()
        {
            items.TryAdd(1, 2);
            WriteLine(items.Count);
        }

        // BITARRAY
        static void Exercise05()
        {
            bool[] preload = new bool[3] { true, false, true };
            BitArray enemyGrid = new BitArray(preload);
            // enemyGrid[0] = false;
            // enemyGrid[1] = true;
            // enemyGrid.Set(2, false);
            foreach (var item in enemyGrid)
            {
                WriteLine(item);
            }
        }

        static void Exercise06()
        {
            // Tuple<int, String, bool> myTuple = new Tuple<int, String, bool> (1,"holla", true);
            var myTuple = Tuple.Create(1, "holla", true);
            WriteLine(myTuple.Item2);
        }

        static void Exercise07()
        {
            Stack<String> pancakes = new Stack<String>();
            pancakes.Push("top");
            pancakes.Push("middle");
            pancakes.Push("bottom");
            foreach (var pancake in pancakes)
            {
                WriteLine(pancake);
            }
            WriteLine(pancakes.Pop());
            WriteLine(pancakes.Peek());
            WriteLine(pancakes.Peek());
        }

        static void Exercise08()
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            foreach (var item in myQueue)
            {
                WriteLine(item);
            }
            WriteLine(myQueue.Dequeue());
        }

        static void Exercise09()
        {
            var myHash = new HashSet<String>();
            myHash.Add("Salam");
            myHash.Add("Salam");
            WriteLine(myHash.Count);
            String[] s = new String[] { "Salam" };
            WriteLine(myHash.Overlaps(s));
        }

        // Threading
        static void Exercise10()
        {
            WriteLine("Download Started");
            // ReadLine();
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                WriteLine("Download Complete");
            });
        }

        static void Exercise11a()
        {
            // ReadLine();
            Thread.Sleep(1000);
            WriteLine("work complete");
        }

        static void Exercise11()
        {
            Thread myThread = new Thread(new ThreadStart(Exercise11a));
            myThread.Start();
        }

        static void Exercise12()
        {
            var point = new { x = 1, y = 2 };
            WriteLine($"x {point.x}, y {point.y}");
        }

        static void Exercise13()
        {
            try
            {
                // throw new PersonException("Kim");
                throw new PersonException("Bob");
            }
            catch (PersonException ex) when (ex.Name == "Kim")
            {
                WriteLine("Its from Kim, lets ignore it");
            }
            catch (PersonException ex) when (ex.Name == "Bob")
            {
                WriteLine("Its from Bob, lets do soemthing");
            }
        }
        class PersonException : Exception
        {
            public PersonException(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
        }

        static void Exercise14()
        {
            using (var resoruce = new MyResource())
            {
                WriteLine("Using my resource");
            }
            WriteLine("Finished!");
        }
        class MyResource : IDisposable
        {
            public void Dispose()
            {
                WriteLine("Disposing our resoruce");
            }
        }




    }
}
