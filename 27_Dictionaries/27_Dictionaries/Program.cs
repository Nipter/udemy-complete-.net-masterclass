namespace _27_Dictionaries
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public int  Age { get; set; }
            public int Salary { get; set; }

            public Employee(string name, int age, int salary)
            {
                Name = name;
                Age = age;
                Salary = salary;
            }
        }
        static void Main(string[] args)
        {
            //// Key - Value
            //// Declaring and initializing dictionary
            //Dictionary<int, string> employees = new Dictionary<int, string>();

            //employees.Add(101, "John Doe");
            //employees.Add(102, "Bob Smith ");
            //employees.Add(103, "Tom Smith ");
            //employees.Add(104, "Hans Smith ");
            //employees.Add(105, "Rob Smith ");

            //// access item
            //string name = employees[101];
            //Console.WriteLine(name);

            //// update data
            //employees[102] = "Jane Smith";

            //// remove data
            //employees.Remove(102);

            //// throws an error when key exists
            //// employees.Add(104, "Mike Jike");

            //if (employees.ContainsKey(104))
            //{
            //    Console.WriteLine("Key 104 is taken");
            //}
            //bool added = employees.TryAdd(104, "Mike Jike");

            //if (!added)
            //{
            //    Console.WriteLine("Could not add at index 104");
            //}

            //// Iteraring over a dictionary
            //foreach (KeyValuePair<int, string> employee in employees)
            //{
            //    Console.WriteLine($"ID: {employee.Key}, name: {employee.Value}");
            //}
            // ----------------------------

            //Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            //employees.Add(1, new Employee("John Doe", 35, 100000));
            //employees.Add(2, new Employee("Tom Doe", 35, 200000));
            //employees.Add(3, new Employee("Anna Doe", 35, 300000));
            //employees.Add(4, new Employee("Hans Doe", 35, 400000));

            //foreach (var emplyee in employees)
            //{
            //    Console.WriteLine($"ID: {emplyee.Key}, name: {emplyee.Value.Name}, age: {emplyee.Value.Age}, salary: {emplyee.Value.Salary}");
            //}
            // ----------------------------

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas",
            };
 

            if(codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The Statecode is {item.Key} and state name is {item.Value}");
            }
        }
    }
}
