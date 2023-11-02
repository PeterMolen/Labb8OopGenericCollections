namespace Labb8OopGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee E1 = new Employee();  // you can do it this way, but i do it the way under.
            //e1.Id = 110;
            //e1.Name = "Johnny";
            //e1.Gender = "Male";
            //e1.Salary = 20000;

            Employee E1 = new Employee() //instans objekt
            {
                Id = 110,  //setting the value of property here
                Name = "Lisa", // -||-
                Gender = "Female", // -||-
                Salary = 40000 // -||-
            };
            Employee E2 = new Employee()
            {
                Id = 111,
                Name = "Johnny",
                Gender = "Male",
                Salary = 25000
            };
            Employee E3 = new Employee()
            {
                Id = 112,
                Name = "Samsam",
                Gender = "Male",
                Salary = 21000
            };
            Employee E4 = new Employee()
            {
                Id = 113,
                Name = "Sarah",
                Gender = "Female",
                Salary = 26000
            };
            Employee E5 = new Employee()
            {
                Id = 114,
                Name = "Alicia",
                Gender = "Female",
                Salary = 30000
            };

            Stack<Employee> stack = new Stack<Employee>();  //stack
            stack.Push(E1); // push == add item
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            foreach (Employee emp in stack) //foreach looop to go thru E1-E5 and to display it as you can se under.
            {
                Console.WriteLine("******STACK*****");
                Console.WriteLine($"ID : {emp.Id} \nName : {emp.Name} \nGender : {emp.Gender} \nSalary : {emp.Salary}");
                Console.WriteLine("Items left in the stack : " + stack.Count());
                Console.WriteLine("_________________");
            }

            //Pop, pop == remove an item from the stack, last in first out, removes item on top, next will show
            Console.WriteLine("******POP*****");
            Employee popEmp1 = stack.Pop();
            Console.WriteLine($"ID : {popEmp1.Id} \nName : {popEmp1.Name} \nGender : {popEmp1.Gender} \nSalary : {popEmp1.Salary}");
            Console.WriteLine("Items left in the stack : " + stack.Count());
            Console.WriteLine("_________________");
            Employee popEmp2 = stack.Pop();
            Console.WriteLine($"ID : {popEmp2.Id} \nName : {popEmp2.Name} \nGender : {popEmp2.Gender} \nSalary : {popEmp2.Salary}");
            Console.WriteLine("Items left in the stack : " + stack.Count());
            Console.WriteLine("_________________");
            Employee popEmp3 = stack.Pop();
            Console.WriteLine($"ID : {popEmp3.Id} \nName : {popEmp3.Name} \nGender : {popEmp3.Gender} \nSalary : {popEmp3.Salary}");
            Console.WriteLine("Items left in the stack : " + stack.Count());
            Console.WriteLine("_________________");
            Employee popEmp4 = stack.Pop();
            Console.WriteLine($"ID : {popEmp4.Id} \nName : {popEmp4.Name} \nGender : {popEmp4.Gender} \nSalary : {popEmp4.Salary}");
            Console.WriteLine("Items left in the stack : " + stack.Count());
            Console.WriteLine("_________________");
            Employee popEmp5 = stack.Pop();
            Console.WriteLine($"ID : {popEmp5.Id} \nName : {popEmp5.Name} \nGender : {popEmp5.Gender} \nSalary : {popEmp5.Salary}");
            Console.WriteLine("Items left in the stack : " + stack.Count());
            Console.WriteLine("_________________");

            //push back all items in stack after i poped them
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            //Peek, peek == to look at item, item on top.
            Console.WriteLine("****PEEK****");
            Employee peekEmp1 = stack.Peek(); //peeks at the top
            Console.WriteLine($"ID : {peekEmp1.Id} \nName : {peekEmp1.Name} \nGender : {peekEmp1.Gender} \nSalary : {peekEmp1.Salary}");
            Console.WriteLine("Items left in the stack : " + stack.Count());
            Console.WriteLine("_____________");
            Employee peekEmp2 = stack.Peek();
            Console.WriteLine($"ID : {peekEmp2.Id} \nName : {peekEmp2.Name} \nGender : {peekEmp2.Gender} \nSalary : {peekEmp2.Salary}");
            Console.WriteLine("Items left in the stack : " + stack.Count());
            Console.WriteLine("__________________________");

            //contatins, == does the item contain in stack or not?
            Console.WriteLine("***CONTAINS IN STACK***");
            if (stack.Contains(E3))
            {
                Console.WriteLine($"ID : {E3.Id} Name : {E3.Name} | finns i stacken");
                Console.WriteLine("__________________________");
            }
            else
            {
                Console.WriteLine($"ID : {E3.Id} Name : {E3.Name} |  finns inte i  stacken");

            }

            //--------------------------------------- Part 2, LIST

            //Create a list and add objekt from each employee
            var employeeList = new List<Employee>();
            employeeList.Add(E1);
            employeeList.Add(E2);
            employeeList.Add(E3);
            employeeList.Add(E4);
            employeeList.Add(E5);

            //containts in list
            Console.WriteLine("***CONTAINS IN LIST***");
            if (employeeList.Contains(E3))
            {
                Console.WriteLine($"ID : {E3.Gender} Name : {E3.Name} | Finns i listan!");

            }
            else
            {
                Console.WriteLine($"ID : {E3.Gender} Name : {E3.Name} | Finns inte i  listan!");
            }
            Console.WriteLine("__________________________");

            //find the first ID in the list that has gender male in it.
            //find all male ID's
            Console.WriteLine("*********initiating search*******");
            Employee find = employeeList.Find(item => item.Gender.Contains("Male"));
            Console.WriteLine($"\nFirst ID that is a Male: {find.Id}: {find.Name}, {find.Gender}");

            List<Employee> findAll = employeeList.FindAll(item => item.Gender.Contains("Male"));
            foreach (Employee all in findAll)
            {
                Console.WriteLine($"ID of all Males: {all.Id}: {all.Name}, {all.Gender}");
            }
            Console.WriteLine("__________Search Completed__________");
        }
    }
}