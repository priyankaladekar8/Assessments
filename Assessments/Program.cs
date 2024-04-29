////single Line comment



//char ch = 'A';

//short s1 = 100;  //2 bytes

//int no = 10;

//long  l1 = 454545; // 8 bytes

//float f1 = 20.44F; //4 bytes

//double d1 = 45.66; //8 bytes


//decimal d3 = 47.65M; //16 bytes


////print the output

//Console.WriteLine("integer number is" + no); //concatination using +sign

////using placholder  OR
//Console.WriteLine("integer number is{0} and float value is{1} ", no, f1);

////String interpolation-->$ OR
//Console.WriteLine($"integar number is{no} and float value is {f1}");*/



////accept the value from user--> Console.ReadLine()--> return string

////Console.WriteLine("Enter your name");
////string name = Console.ReadLine();


////Console.WriteLine("Enter your age");
////int age = Convert.ToInt32(Console.ReadLine());

////Console.WriteLine("Enter your salary");
////double salary = Convert.ToDouble(Console.ReadLine());

////Console.WriteLine($"Hello {name}, your age is{age} and salary is{salary}");


////write a code to calculate the area of circle
////write a code to perform a swaping of two numbers
////write a code to calculate area of triangle 
////write a code to calculate the percentage for the 5 subject marks



////using Assessments;
//////main method is declared by default by the program

//////declare object
//////new keyword allocate the memory on heap

////Employee emp = new Employee();

////emp.Assign();
////emp.CalculateSalary();
////string result = emp.Display();
////Console.WriteLine(result);


////
////Employee emp2 = new Employee();
////emp2.Accept(101, "priyanka", 4500.56, 3200.44, 500.50);
////emp2.CalculateSalary();
////Console.WriteLine(emp2.Display());


////using Assessments;

//////Student object
////Student stud = new Student();
////Student s1 = new Student(2, "Priyanka");

////Console.WriteLine(stud.Display());
////Console.WriteLine(s1.Display());

////using Assessments;
////Date d1 = new Date();
////Date d2 = new Date(13, 04, 2025);

////Console.WriteLine(d1.Display());
////Console.WriteLine(d2.Display());

////using Assessments;
////using System.Runtime.InteropServices;

////working with property,
//// property initilizer syntax

////Product p1=new Product();
////    p1.Code = 101;//internally it calles set acccessor
////    p1.Name = "Mouse";
////    p1.Price= 999;

////Console.WriteLine($"{p1.Code}, {p1.Name}, {p1.Price}");

////object initilizer Syntax
////Product p2 = new Product { Code = 102, Name= "Keyboard", Price = 399 };
////Console.WriteLine($"{p2.Code}, {p2.Name}, {p2.Price}");



////Que. create Book class with auto implemnted Propertied
////Create object with property syntax and object initilizer syntax
////display the book details


////Property Inititializer syntax
////Book b1 = new Book();
////b1.Id = 101;
////b1.Name = "dotnet ";
////b1.Price = 599.99;


////Book b2 = new Book { Id = 102, Name = "HTML", Price = 399 };
////Console.WriteLine($"{b2.Id}, {b2.Name}, {b2.Price}");


////using Assessments;

////Employee emp = new Employee(1, "Amol", 2000, 1000, 250);
////emp.CalculateSalary();
////Console.WriteLine(emp.Display());

//////Object of child class

////Manager man1 = new Manager(2, "Suraj", 3000, 2000, 500, 1000);
////man1.CalculateSalary();
////Console.WriteLine(man1.Display());

//////Create ref of base class ,but object of child class
////Employee e1 = new Manager(3, "Khishor", 4000, 2000, 500, 1000);
////e1.CalculateSalary();
////Console.WriteLine(e1.Display());

////dynamic binding / run time binding in polymorphism /in method overrideing
////e1.ColaculateSalary()--> at run time method get bind with object

////e2 = emp;//e2 is a employee type


////using Assessments;

////Circle c1 = new Circle(5);
////c1.CalculateArea();


////Console.WriteLine(c1.print());


////  Rectangle r1 = new Rectangle(8.5, 6.3);
////    r1.CalculateArea();

////code in main method
////using static Assessments.ITaxable.Job;
////using static Assessments.ITaxable;
////using Assessments;

////Job j1 = new Job();
////Console.WriteLine(j1.PayTax());

////Business b1 = new Business();
////Console.WriteLine(b1.PayTax());


////Code in main method

//// working with explict interface implemenation

////ICustomer c1 = new Trasaction();

////Console.WriteLine(c1.Print()); // customer 

////IOrder o1 = new Trasaction();
////Console.WriteLine(o1.Print()); // order

////Calc c = new Calc();

////Console.WriteLine(c.Sub(30, 20));

////Console.WriteLine(c.Add(20, 60));



////using Assessments;

////Shopping item1 = new Shopping(1, "Product A", 10.5, 2);
////Shopping item2 = new Shopping(2, "Product B", 20.75, 3);
////Shopping item3 = new Shopping(3, "Product C", 15.25, 0);

////Console.WriteLine("Shopping Details:");
////Console.WriteLine("-----------------");
////Console.WriteLine("Item 1:");
////item1.DisplayShoppingDetails();
////Console.WriteLine();

//////Console.WriteLine("Item 2:");
////item2.DisplayShoppingDetails();
////Console.WriteLine();

////Console.WriteLine("Item 3:");
////item3.DisplayShoppingDetails();
////Console.WriteLine();

////Console.ReadLine();


////using Assessments;

////Product1 [] products = new Product1[5];


////products[0] = new Product1 ("Laptop", 999.99, "Powerful laptop for work and gaming");
////products[1] = new Product1 ("Smartphone", 699.99, "High-end smartphone with advanced features");
////products[2] = new Product1 ("Headphones", 149.99, "Noise-cancelling headphones for immersive audio experience");
////products[3] = new Product1 ("Smartwatch", 249.99, "Fitness tracker and smartwatch with heart rate monitoring");
////products[4] = new Product1 ("Camera", 799.99, "Professional DSLR camera with 4K video capabilities");


////foreach (Product1 product1 in products)
////{
////    Console.WriteLine("Name: " + product1.Name);
////    Console.WriteLine("Price: $" + product1.Price);
////    Console.WriteLine("Description: " + product1.Description);
////    Console.WriteLine();


////int[] arr1 = new int[] { 80, 45, 12, 78, 1 };
////int[] arr2 = new int[3];

////String[] str = { "vikash", "akash", "shital", "priya", "puja" };
////string[] str2 = { "shital", "priya", "vikash" };
//////print as it is
////foreach (int item in arr1)
////{
////    Console.WriteLine(item);

////}
//////sort the elements
////Array.Sort(arr1);
////Console.WriteLine("-----After sort--------------");
////foreach (int item in arr1)
////{
////    Console.WriteLine(item);
////}

//////print reverse

////Array.Reverse(arr1);
////Console.WriteLine("-----after reverse-----");
////foreach (int item in arr1)
////{
////    Console.WriteLine(item);
////}

//////copy the 3 elements 45,12,1 in the new array

//////int[]arr2 = new int[3];
////Array.Copy(arr1,2,arr2,0,3); //sourcearray,sourceindex, destinationarray ,destinationindex, lenght 3 elements
////Console.WriteLine("---aftercoppy-----");
////foreach (int item in arr1)
////{
////    Console.WriteLine(item);
////}

//////copy the 3 elements 45 ,12,1 in the new array
////Array.Clear(arr1, 0, 3);
////Console.WriteLine("---after copy----");
////foreach (int item in arr1)
////{
////    Console.WriteLine(item);

////}

////Array.Reverse(str);
////Console.WriteLine("-----after reverse-----");
////foreach (string item in str)
////{
////    Console.WriteLine(item);
////}

////copy the 3 elements 45,12,1 in the new array

////int[]arr2 = new int[3];
////Array.Copy(str, 2, str2, 0, 3); //sourcearray,sourceindex, destinationarray ,destinationindex, lenght 3 elements
////Console.WriteLine("---aftercoppy-----");
////foreach (string i in str)
////{
////    Console.WriteLine(i);
////}

//////copy the 3 elements 45 ,12,1 in the new array
////Array.Clear(str, 0, 3);
////Console.WriteLine("---after copy----");
////foreach (string i in str)
////{
////    Console.WriteLine(i);

////}

////2D array / 2 dimensional array




//// row,column
////using System.Data;

////int[,] arr = new int[3, 4];

////// initialize value

////int[,] arr2 = new int[3, 4]
////{
////    {1,2,3,4 },
////    {10,20,30,40 },
////    {100,200,300,400 }
////};

////Console.WriteLine(arr2[1, 2]);

////arr2[2, 3] = 4000;

//////nested for loop
////for (int i = 0; i < arr2.GetLength(0); i++) // row size
////{
////    for (int j = 0; j < arr2.GetLength(1); j++) // col size
////    {
////        Console.Write($"arr2[{i},{j}] --> {arr2[i, j]}  ");
////    }
////    Console.WriteLine();
////}


////using Assessments;

////ChildClass c = new ChildClass(6, 7);

////int add = c.PerformOperation(10);
////Console.WriteLine(add);

////int add2 = c.PerformOperation();
////Console.WriteLine(add2);


////jaged array
////int[][] arr = new int[3][];// row  are fixed

////arr[0] = new int[] { 1, 2, 3, 4 };
////arr[1] = new int[] { 10, 20, 30 };
////arr[2] = new int[] { 100, 200 };

//////row
////for (int i = 0; i < arr.Length; i++)
////{
////    for (int j = 0; j < arr[i].Length; j++)
////    {
////        Console.WriteLine($"{arr[i][j]}");
////    }
////    Console.WriteLine();
////}
//////with foreach
////Console.WriteLine("-------------------Using foreach------------------------");
////foreach (int[] item in arr) //assing row to item
////{
////    foreach (int i in item)
////    {
////        Console.WriteLine($"{i}");
////    }
////    Console.WriteLine();
////}

////Sting in c#

////string str = "Hello to all";
////string str2 = "Hello";
////// need to convert string to char[]

////char[] chs = str.ToCharArray();
////foreach (var item in chs)
////{
////    Console.WriteLine(item);
////}
//////split  --> string to string[] using condition

////string[] result = str.Split(' ');

////// result[0]="Hello"
////// result[1]="to"
//////result[2]="all"

////foreach (var item in result)
////{
////    Console.WriteLine(item);
////}

////if (string.IsNullOrEmpty(str2))
////{
////    Console.WriteLine("string is empty or null");
////}
////else
////{
////    Console.WriteLine(str2);
////}




////String in c#


//using Assessments;
//using System.Collections;
//using System.Text;

////string str = "Hello";

////Console.WriteLine(str);
////Console.WriteLine($"address of str {str.GetHashCode()}");// object class method

////str = "hello Hi";
////Console.WriteLine("---after changed value");
////Console.WriteLine(str);
////Console.WriteLine($"address of str {str.GetHashCode()}");

////str = str + " good morning";
////Console.WriteLine("---after changed value");
////Console.WriteLine(str);
////Console.WriteLine($"address of str {str.GetHashCode()}");

//////StringBuilder in C#
////Console.WriteLine("----------StringBuilder class");

//StringBuilder sb = new StringBuilder();
//sb.Append("Hello");
////Console.WriteLine(sb);
////Console.WriteLine($"address of sb {sb.GetHashCode()}");

////Console.WriteLine("-----after changed the value");
////sb.Append("Hello to all");
////Console.WriteLine(sb);
////Console.WriteLine($"address of sb {sb.GetHashCode()}");


////Console.WriteLine($"Initial string: {sb}");
////Console.WriteLine($"Initial Length: {sb.Length}");
////Console.WriteLine($"Initial Capacity: {sb.Capacity}");
////Console.WriteLine("----------------------------------");

////// Remove characters from the StringBuilder
////sb.Remove(5, 6);                    // Removes " World" starting from index 5
////Console.WriteLine($"After Remove: {sb}");
////Console.WriteLine($"Length after Remove: {sb.Length}");
////Console.WriteLine($"Capacity after Remove: {sb.Capacity}");
////Console.WriteLine("-----------------------------------");

////// Replace 
////sb.Replace("l", "L");                     // Replaces all occurrences of "l" with "L"
////Console.WriteLine($"After Replace: {sb}");
////Console.WriteLine($"Length after Replace: {sb.Length}");
////Console.WriteLine($"Capacity after Replace: {sb.Capacity}");
////Console.WriteLine("-------------------------------------");

////// Clear 
////sb.Clear();
////Console.WriteLine($"After Clear: {sb}");
////Console.WriteLine($"Length after Clear: {sb.Length}");
////Console.WriteLine($"Capacity after Clear: {sb.Capacity}");
////Console.WriteLine("-----------------------------------");

////// Append 
////sb.Append("New Content");
////Console.WriteLine($"After Append: {sb}");
////Console.WriteLine($"Length after Append:{sb}");
////Console.WriteLine($"Capacity after Append: {sb.Capacity}");
////Console.WriteLine("---------------------------------------");


////////Collections

//////// Main()
//////int[] arr = new int[] { 15, 22, 38 };

//////ArrayList list = new ArrayList(); // u can also set the default initial value of ArrayList

//////// methods of ArrayList

////////list.Add(10);
//////list.Add(56.66);
//////list.Add("Hello");
//////list.Add(new Product { Id = 1, Name = "Pen", Price = 10 });


////list.Add(45);
////list.Add(88);
////list.Add(11);
////list.AddRange(arr);

//////list.RemoveAt(2); // 2 is index
//////list.Remove(20); // remove based on object / element present in the collection
//////list.RemoveRange(1, 3);// remove multiple values from collections

//////list.Clear(); // clear list at once

////list.Sort();//asc
////list.Reverse();//desc
////Console.WriteLine($"Total elements in list = {list.Count}");
////foreach (var item in list)
////{
////    Console.WriteLine(item);
////}




////Homework

////using System.Collections;
////using System.Text;

////string str = "Hello to all";
////string str2 = "Hello";

////static bool IsEmptyOrNull(string str)
////{
////    return string.IsNullOrEmpty(str);
////}

////static string Concat(string str1, string str2)
////{
////    return string.Concat(str1, str2);
////}

////static char CharAt(string str, int index)
////{
////    return str[index];
////}

////static char[] ToCharArray(string str)
////{
////    return str.ToCharArray();
////}

////static string ToUpper(string str)
////{
////    return str.ToUpper();
////}

////static string ToLower(string str)
////{
////    return str.ToLower();
////}

////static int IndexOf(string str, string value)
////{
////    return str.IndexOf(value);
////}

////static int LastIndexOf(string str, char value)
////{
////    return str.LastIndexOf(value);
////}

////static string Substring(string str, int startIndex, int length)
////{
////    return str.Substring(startIndex, length);
////}

////static bool Contains(string str, string value)
////{
////    return str.Contains(value);
////}

////static string[] Split(string str, char separator)
////{
////    return str.Split(separator);
////}

////static string Trim(string str)
////{
////    return str.Trim();
////}
////Console.WriteLine($"Is string empty or null? {IsEmptyOrNull(str)}");

////Console.WriteLine("---------------------------------------");

////string concatResult = Concat(str, str2);
////Console.WriteLine($"Concatenated string: {concatResult}");
////Console.WriteLine("---------------------------------------");
////char charAtIndex = CharAt(str, 2);
////Console.WriteLine($"Character at index 2: {charAtIndex}");

////Console.WriteLine("---------------------------------------");
////char[] charArray = ToCharArray(str);
////Console.WriteLine("Characters in the string:");
////foreach (var item in charArray)
////{
////    Console.WriteLine(item);
////}
////Console.WriteLine("---------------------------------------");
////string upperCase = ToUpper(str);
////Console.WriteLine($"Uppercase string: {upperCase}");
////Console.WriteLine("---------------------------------------");


////string lowerCase = ToLower(str);
////Console.WriteLine($"Lowercase string: {lowerCase}");
////Console.WriteLine("---------------------------------------");

////int indexOfHello = IndexOf(str, "Hello");
////Console.WriteLine($"Index of 'Hello': {indexOfHello}");
////Console.WriteLine("---------------------------------------");

////int lastIndexOfL = LastIndexOf(str, 'l');
////Console.WriteLine($"Last index of 'l': {lastIndexOfL}");
////Console.WriteLine("---------------------------------------");

////string subString = Substring(str, 6, 2);
////Console.WriteLine($"Substring from index 6 with length 2: {subString}");
////Console.WriteLine("---------------------------------------");

////bool containsHello = Contains(str, "Hello");
////Console.WriteLine($"Does string contain 'Hello'? {containsHello}");
////Console.WriteLine("---------------------------------------");

////string[] splitStrings = Split(str, ' ');
////Console.WriteLine("Split string:");
////foreach (var splitStr in splitStrings)
////{
////    Console.WriteLine(splitStr);
////}

////nameException object

//Person p1 = new Person();
//try
//{
//    p1.AcceptName("null");
//}
//catch(NameException ex)
//{
//    Console.WriteLine(ex.Message);
//}



//Main delegate

//using Assessments;

/////* multiple comment in c#*/
/////*string name = "priyanka";
//Calculator c1 = new Calculator();

//MyDelegate mydelegate = new MyDelegate(c1.Add);
//mydelegate += new MyDelegate(c1.Sub);
//mydelegate += new MyDelegate(c1.Mul);

////to remove method from invocation list
//mydelegate -= new MyDelegate(c1.Sub);

////to get the invocation list to retrieve the methods from delegate

//Delegate[] list = mydelegate.GetInvocationList();

//foreach (Delegate item in list)
//{
//    Console.WriteLine(item.Method);
//    Console.WriteLine(item.DynamicInvoke(45, 35));

//}
////this is in case of single cast delete
//int result=mydelegate.Invoke(20,40);
//Console.WriteLine(result);


//main event
//Bank bank = new Bank();
//MyMessage msg = new MyMessage();
//// if lowbalance event raised than call the MyBankDelegate & then delete will call balacemsg method
//bank.LowBalance += new MyBankDelete(msg.BalanceMsg);
//Console.WriteLine("Inital balance");
//Console.WriteLine(bank);

//bank.Withdraw(1000);
//Console.WriteLine("balance after withdraw 1000");
//Console.WriteLine(bank);

//bank.Withdraw(6000);
//Console.WriteLine("balance after withdraw 6000");
//Console.WriteLine(bank);



