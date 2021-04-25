using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using ExtensionMethods;
using LinkedListImplementation;
using OOPS_CONCEPTS;

namespace OOpS_CONCEpTS
{
    public class Employee
    {

        //OOP is faster and easier to execute
        //OOP provides a clear structure for the programs
        //OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
        //OOP makes it possible to create full reusable applications with less code and shorter development time

        //CLASS AND OBJECTS DEFINE

        string model;
        string color;
        int year;
        int AgeTryCatch = 5;

        public const int VALUE = 10;
        public readonly int Value1;
        public delegate int FunctionPointer(int x, int y);
        delegate int func(int a, int b);

        int? iChkNull = null;
        //var? i = null;

        #region Calling a Method

        public void fullThrottle()  // Global method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        #endregion

        #region Inheritance Example
        public string IDEmpl { get; set; }
        public string NameEmpl { get; set; }

        public float salaryEmpl = 400;
        public class ProgrammerEmpl : Employee
        {
            public float bonus = 100;
        }

        #endregion

        #region Method Hiding

        //A concept to hide the methods of the base class from derived class, this concept is known as Method Hiding.
        //You can hide the implementation of the methods of a base class from the derived class using the new keyword.

        class Car
        {
            public void TypeOfDrive()
            {
                Console.WriteLine("Right Hand Drive");
            }
        }

        class Ford : Car
        {
            public new void TypeOfDrive()
            {
                Console.WriteLine("Right Hand ");
            }
        }

        #endregion

        #region PassByVal & Ref
        static void ChangeValue(int x)
        {
            x = 200;
        }
        public static void Multiplication(ref int a)
        {
            a *= a;
        }

        #endregion

        #region ReadonlyAndConstant

        //Readonly is used to define a variable which can be assigned once after declaration either during declaration or in constructor. 
        //const keyword is used to define a constant to be used in the program.

        readonly int read = 10;
        const int cons = 10;

        public void CheckReadonlyAndConstant()
        {

            Console.WriteLine("Read only : {0}", read);
            Console.WriteLine("const : {0}", cons);
        }

        #endregion

        #region Const,Static,Readonly

        //Const is "constant", a variable for which the value is constant but at compile time and it's mandatory to assign a value to it.
        //By default a const is static and we cannot change the value of a const variable throughout the entire program.

        //Readonly is the keyword whose value we can change during runtime or we can assign it at run time 
        //but only through the non-static constructor.

        // A Static Readonly type variable's value can be assigned at runtime or assigned at compile time and changed at runtime.
        //But this variable's value can only be changed in the static constructor.And cannot be changed further.
        //It can change only once at runtime.

        public class ConstSum
        {
            const int i = 9, k = 2;
            const int A = i + k;
            //const int B = i + j; J will have to be decalared else gives complile time error
        }

        public class ReadOnly
        {
            readonly int i;
            public ReadOnly()
            {
                i = 11;
                Console.WriteLine(i);
            }
        }
        public class Static
        {
            static int i = 11;
            public static void disp()
            {
                Console.WriteLine(i);
            }
        }

        public class Static2
        {
            int i = 9;
            public static void disp()
            {
                //Console.WriteLine(i); // need to use static during variable declaration
            }
        }

        #endregion

        #region GetSetExample
        public class Person
        {
            public string name; // field
            public string Name   // property
            {
                get { return name; }
                set { name = value; }
            }
        }
        public class GetSetExample
        {
            public string GetsetMethod()
            {
                Person myObj = new Person();
                myObj.Name = "Liam";
                return myObj.Name;
            }
        }
        #endregion

        #region SingleandMultiDimension Array
        int[] score = new int[4] { 25, 24, 23, 25 };
        int[,] numbersMultiDArray = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };

        #endregion

        #region AccessModifiers

        class PhoneMake
        {
            private string PhoneModelPrivate;
            public string PhoneModelPublic;
            protected int numberProtected;
            internal string Location_Internal;
            protected internal string Age_ProtectedInternal;

        }

        #endregion

        #region Generics

        public class TestClass<T>
        {
            // define an Array of Generic type with length 5  
            T[] obj = new T[5];
            int count = 0;

            // adding items mechanism into generic type  
            public void Add(T item)
            {
                //checking length  
                if (count + 1 < 6)
                {
                    obj[count] = item;

                }
                count++;
            }
            //indexer for foreach statement iteration  
            public T this[int index]
            {
                get { return obj[index]; }
                set { obj[index] = value; }
            }
        }

        public class Check
        {
            public bool Compare(int a, int b)
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Check<REPLACEDATATYPE>
        {
            public bool Compare(REPLACEDATATYPE a, REPLACEDATATYPE b)
            {
                if (a.Equals(b))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static Dictionary<string, string> _methodDictionary;
        private static Dictionary<string, string> GetMethodsDictionary()
        {
            var dictionary = new Dictionary<string, string>
        {
            {"GetName", "GetName"},
            {"GetUniversity", "GetUniversity"},
            {"GetRoll","GetRoll"}
        };
            return dictionary;
        }
        public class Student
        {
            public string Name { get; set; }
            public string University { get; set; }
            public int Roll { get; set; }
        }
        class StudentFunction
        {
            private Student student;
            public StudentFunction()
            {
                student = new Student
                {
                    Name = "Gopal C. Bala",
                    University = "Jahangirnagar University",
                    Roll = 1424
                };
            }
            public string GetName()
            {
                return student.Name;
            }
            public string GetUniversity()
            {
                return student.University;
            }
            public int GetRoll()
            {
                return student.Roll;
            }
        }

        #endregion

        #region Enums
        enum Level
        {
            Low,
            Medium,
            High
        }

        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }

        #endregion

        #region Interface

        //Another way to achieve abstraction in C#, is with interfaces.
        //An interface is a completely "abstract class", which can only contain abstract methods and properties(with empty bodies)
        interface IAnimal
        {
            void animalSound(); // interface method (does not have a body)
        }

        public class InterfacePig : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

        #region Implicit Interface
        interface ITest
        {
            void TestMethod();
        }

        class TestClass : ITest
        {
            public void TestMethod()
            {
                Console.WriteLine("Implicit Interface Implementation");
            }
        }

        #endregion

        #region Explicit Interface
        class TestClassExplicit : ITest
        {
            void ITest.TestMethod()
            {
                Console.WriteLine("Explicit Interface Implementation");
            }
        }

        #endregion

        #endregion

        #region InterfaceWithConflictNames

        interface testInterface1
        {
            void Show();
        }
        interface testInterface2
        {
            void Show();
        }
        class Abc : testInterface1,
            testInterface2
        {
            void testInterface1.Show()
            {
                Console.WriteLine("For testInterface1 !!");
            }
            void testInterface2.Show()
            {
                Console.WriteLine("For testInterface2 !!");
            }
        }

        #endregion

        #region AsISOperators
        class Class1
        {
        }
        class Class2
        {

        }

        public static void Test(object o)
        {
            Class1 a;
            Class2 b;
            if (o is Class1)
            {
                Console.WriteLine("o is Class1");
                a = (Class1)o;
            }
            else if (o is Class2)
            {
                Console.WriteLine("o is Class2");
                b = (Class2)o;
            }
            else
            {
                Console.WriteLine("o is neither Class1 nor Class2.");
            }
        }

        #endregion

        #region Abstract class [AbstractBaseclas]
        abstract class animalAbstractBaseclass
        {
            public abstract void eat();
            public void sound()
            {
                Console.WriteLine("dog can sound");
            }
        }
        class dog : animalAbstractBaseclass
        {
            public override void eat()
            {
                Console.WriteLine("dog can eat");
            }
        }

        #endregion

        #region Encapsulation Eg 
        public class Department
        {
            private string departname;

            // Accessor.  
            public string GetDepartname()
            {
                return departname;
            }
            // Mutator.  
            public void SetDepartname(string a)
            {
                departname = a;
            }
        }

        #endregion

        #region Indexer

        //Indexers are usually known as smart arrays. It is a class property that allows you to access a 
        //member variable of a class or struct using the features of an array. In C#, indexers are created using this keyword.
        //Indexers in C# are applicable on both classes and structs.
        class IndexerClass
        {
            private string[] names = new string[10];
            public string this[int i]
            {
                get
                {
                    return names[i];
                }
                set
                {
                    names[i] = value;
                }
            }
        }

        #endregion

        #region Override ExtensionMethod
        public class EmployeeTostringOverride
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string DeptName { get; set; }
            public override string ToString()
            {
                return this.EmpId + " " + this.EmpName + " " + this.DeptName;
            }
        }

        #endregion

        #region Multiple Rtns

        //We can return multiple values from a function using the following 3 approaches:

        //Reference parameters
        //Output parameters
        //Returning an Array

        public static int MultipleReturns(int a, int b, ref int max)
        {
            if (a < b)
            {
                max = a;
                return b;
            }
            else
            {
                max = b;
                return a;
            }
        }

        public static int[] MultipleReturnsWithArray(int a, int b)
        {
            int[] minMax = new int[5];
            if (a > b)
            {
                minMax[0] = a;
                minMax[1] = b;
            }
            else
            {
                minMax[0] = b;
                minMax[1] = a;
            }
            return minMax;
        }

        #endregion

        #region Tuple

        //Tuple < T > A tuple is a data structure that contains a sequence of elements of different data types.
        //It can be used where you want to have a data structure to hold an object with properties of differnt datatype
        public static void DisplayTuple(Tuple<int, string, string> tupPerson)
        {
            Console.WriteLine($"Id = { tupPerson.Item1}");
            Console.WriteLine($"First Name = { tupPerson.Item2}");
            Console.WriteLine($"Last Name = { tupPerson.Item3}");
        }

        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }

        #endregion

        #region OutAndRef

        //The ref keyword passes arguments by reference.
        //Changes made to this argument in the method will be reflected in that variable when control returns to the calling method.
        public static string RefExample(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }

        //The out keyword passes arguments by reference.
        //This is very similar to the ref keyword.
        public static string OutExample(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }

        #endregion

        public static void Compare(int a, int b)
        {
            string output = a > b ? "A is greater than B" : "B is greater than A";
            Console.WriteLine(output);
            string output1 = a > b ? "A is greater than B" : a == b ? "A is equal to B" : "B is greater than A";
            Console.WriteLine(output1);

        }

        #region Refelections
        public virtual int Add(int numb1, int numb2)
        {
            return numb1 + numb2;
        }

        public virtual int Subtract(int numb1, int numb2)
        {
            return numb1 - numb2;
        }

        #endregion

        #region Recursion
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public static double FactorialRec(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * FactorialRec(number - 1);//Recursive call    
            }
        }

        #endregion

        #region Regex in C#
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        private static void showMatchPattern(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        #endregion

        #region Polymorphism

        //It is also known as Early Binding.Method overloading is an example of Static Polymorphism.
        //In overloading, the method / function has a same name but different signatures. 
        //It is also known as Compile Time Polymorphism because the decision of which method is to be called is made at compile time. Overloading is the concept in which method names are the same with a different set of parameters.

        public class TestData
        {
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            public int Add(int a, int b)
            {
                return a + b;
            }
        }


        #region Static Or Compile Time

        class PolyMorphEg
        {
            public void Show()
            {
                Console.WriteLine("This is 'Show' Without Argumant ");
            }
            public void Show(int num1, string str1)
            {
                Console.WriteLine("This is 'Show' With 2 Argumant ");
            }
            public void Show(string str1, int num1)
            {
                Console.WriteLine("This is 'Show' With 2 Argumant Difference in Sequence of Paramanters");
            }
            public void Show(string str1, string str2)
            {
                Console.WriteLine("This is 'Show' With 2 Argumant but Different in Type ");
            }
            public void Show(string str1, string str2, string str3)
            {
                Console.WriteLine("This is 'Show' With 3 Argumant Difference in Number of Paramanters");
            }
        }

        #endregion

        class AnotherClass
        {
            public void Display()
            {
                //we have Called all the Oveloaded Methods by using single instance of the class.  
                PolyMorphEg obj = new PolyMorphEg();
                obj.Show();
                obj.Show(1, "test");
                obj.Show("text", 5);
                obj.Show("AAA", "BBB", "CCC");
                obj.Show("AAA", "XXX");
            }

        }


        #endregion

        #region Dynamic / Runtime Polymorphism
        public class Drawing
        {
            public virtual double Area()
            {
                return 0;
            }
        }

        public class Circle : Drawing
        {
            public double Radius { get; set; }
            public Circle()
            {
                Radius = 5;
            }
            public override double Area()
            {
                return (3.14) * Math.Pow(Radius, 2);
            }
        }

        public class Square : Drawing
        {
            public double Length { get; set; }
            public Square()
            {
                Length = 6;
            }
            public override double Area()
            {
                return Math.Pow(Length, 2);
            }
        }

        public class Rectangle : Drawing
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public Rectangle()
            {
                Height = 5.3;
                Width = 3.4;
            }
            public override double Area()
            {
                return Height * Width;
            }
        }

        #endregion

        #region PreventOverride
        public class XOverride
        {
            public virtual void A()
            {

            }
        }
        public class YOverRide : XOverride
        {
            public override void A()
            {

            }
        }

        #endregion

        #region Optional Params
        public class OPtionalParams
        {
            public int AddNumbers(int number1, int number2, int number3 = 0)
            {
                return number1 + number2 + number3;
            }

        }

        #endregion

        #region OperationswithConstants
        public class ConsOperations
        {
            public void DoMath(int number1, int number2, out int addedValue, out int subtractedValue)
            {
                addedValue = number1 + number2;
                subtractedValue = number1 - number2;
            }

            const int Cons_a = 10;
            const float b = Cons_a * 2.5f;

            const string Cons_s1 = "Hello, world!";
            const string s2 = Cons_s1 + " How are you?";

            // NOT possible:
            //const int a = Math.Cos(4) * 2;
            // Possible:
            const string Cons_s3 = "Hello, world!";
            // NOT possible:
            //const string Cons_s4 = Cons_s3.Substring(0, 6) + " Universe";
        }

        #endregion

        #region Base class virtual
        public class XBaseclass
        {
            public virtual void A()
            {
            }
        }
        public class YBase : XBaseclass
        {
            public override void A()
            {
                base.A();
            }
        }

        #endregion

        #region MethodOverloading
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        public class Shape
        {
            public void Area(float r)
            {
                float a = (float)3.14 * r;
                // here we have used function overload with 1 parameter.
                Console.WriteLine("Area of a circle: {0}", a);
            }

            public void Area(float l, float b)
            {
                float x = (float)l * b;
                // here we have used function overload with 2 parameters.
                Console.WriteLine("Area of a rectangle: {0}", x);

            }

            public void Area(float a, float b, float c)
            {
                float s = (float)(a * b * c) / 2;
                // here we have used function overload with 3 parameters.
                Console.WriteLine("Area of a circle: {0}", s);
            }
        }

        #endregion

        #region MethodOverriding

        //This is also a form of Polymorphism
        //Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.

        class Animal  // Base class (parent) 
        {
            public void animalSoundNoDerived()
            {
                Console.WriteLine("The animal makes a sound");
            }
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public void animalSoundDerived()
            {
                Console.WriteLine("The pig says: wee wee");
            }

            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public void animalSoundDerived2()
            {
                Console.WriteLine("The dog says: bow wow");
            }

            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        #endregion

        #region MethodOverriding With New Keywrd
        class SampleA
        {
            public virtual void Show()
            {
                Console.WriteLine("Sample A Test Method");
            }
        }
        class SampleB : SampleA
        {
            public override void Show()
            {
                Console.WriteLine("Sample B Test Method");
            }
        }

        #endregion

        #region OperatorOverload

        //Spl Purpose C# operator with respect to a user defined data type such as classes or structures is known as operator overloading. 
        class Complex
        {
            private int x;
            private int y;
            public Complex()
            {
            }
            public Complex(int i, int j)
            {
                x = i;
                y = j;
            }
            public void ShowXY()
            {
                Console.WriteLine("{0} {1}", x, y);
            }
            public static Complex operator -(Complex c)
            {
                Complex temp = new Complex();
                temp.x = -c.x;
                temp.y = -c.y;
                return temp;
            }
        }

        #endregion

        #region Creating Constructor

        public string Carmodel;
        public Employee()  //Default Constructor
        {
            Carmodel = "Mustang";
        }

        public Employee(string modelName) // Constuctor with Params
        {
            model = modelName;
        }

        private string name;
        private int age;
        public Employee(Employee emp) //Copy Constructor has Same name as Class name in Param
        {
            name = emp.name;
            age = emp.age;
        }

        public Employee(string name, int age)  // Instance constructor.  
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get deatils of employee  
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }

        #endregion

        #region Inheritance
        public class PassVehicle  // base class (parent) 
        {
            public string brand = "Ford";  // Vehicle field
            public void honk()             // Vehicle method 
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }

        public class MyCar : PassVehicle  // derived class (child)
        {
            public string modelName = "Mustang";  // Car field
        }

        #region  Inheritance Example1
        public class parentClass
        {
            public parentClass()
            {
                Console.WriteLine("parent Constructor.");
            }
            public void print()
            {
                Console.WriteLine("I'm a parent Class.");
            }
        }
        public class ChildClass : parentClass
        {
            public ChildClass()
            {
                Console.WriteLine("Child Constructor.");
            }
        }

        #endregion

        #region Inheritance Example2

        public class A
        {
            public void A_Method()
            {
                Console.WriteLine("Class A Method Called");
            }
        }
        public class B : A
        {
            public void B_Method()
            {
                Console.WriteLine("Class A Method Called");
            }
        }
        public class C : B
        {
            public void C_Method()
            {
                Console.WriteLine("Class A Method Called");
            }
        }

        #endregion

        #endregion

        #region AbstractClass

        //Data abstraction is the process of hiding certain details and showing only essential information to the user.
        //Abstraction can be achieved with either abstract classes or interfaces
        public abstract class WildAnimal
        {
            public abstract void WildanimalSoundAbs(); /// Abstract method (does not have a body)
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
            public abstract void SpaceRocket(); /// Abstract method (does not have a body)
            public void Spacesleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        class WildPigAbstract : WildAnimal
        {
            public override void WildanimalSoundAbs()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
            public override void SpaceRocket()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }

            public void AddAnimal()
            {
                Console.WriteLine("FromDerivedClass");
            }
        }

        #endregion

        #region Coupling

        #region TightCoupling

        //Tight Coupling is when in a group, classes are highly dependent on one another.
        //when a class assumes too many responsibilities or when one Responsiblity is spread over many classes rather than having its own class.

        public class CustomerRepository
        {
            private readonly Database database;
            public CustomerRepository(Database database)
            {
                this.database = database;
            }
            public void Add(string CustomerName)
            {
                database.AddRow("Customer", CustomerName);
            }
        }
        public class Database
        {
            public void AddRow(string Table, string Value) { }
        }

        #endregion

        #region LooseCoupling

        //Loose Coupling is achieved by means of a design that promotes single-responsibility and separation of concerns.
        //A loosely-coupled class can be consumed and tested independently of other classes.
        //Interfaces are powerful tools used for decoupling.
        //Classes can communicate through interfaces to other classes by implementing the interface.

        public class CustomerRepositoryTight
        {
            private readonly IDatabase database;
            public CustomerRepositoryTight(IDatabase database)
            {
                this.database = database;
            }
            public void Add(string CustomerName)
            {
                database.AddRow("Customer", CustomerName);
            }
        }
        public interface IDatabase
        {
            void AddRow(string Table, string Value);
        }
        public class SqlDatabase : IDatabase
        {
            public void AddRow(string Table, string Value)
            {
                //Logic to add new customer in sql table  
            }
        }
        public class XMLDatabase : IDatabase
        {
            public void AddRow(string Table, string Value)
            {
                //Logic to add new customer in XML Document  
            }
        }

        #endregion

        #endregion

        #region LinqDeclare

        public class LinqEmployeeIExec
        {
            public int Emp_ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }

        }

        public class LinqStudent
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int age { get; set; }
        }

        class LinqDog
        {
            public string LinqName { get; set; }
            public int LinqAge { get; set; }
        }

        class LinqEmployee
        {
            public string Name { get; set; }
            public List<string> Skills { get; set; }
        }

        class LinqclsTest
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class LinqStudentList
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }
        }

        public class LinqEmployeeJoin
        {
            public int Id { get; set; }
            public int age { get; set; }
            public string name { get; set; }
            public string gender { get; set; }
        }
        public class LInqDepartmentJoin
        {
            public int id { get; set; }
            public string Departments { get; set; }
            public string Location { get; set; }
        }

        public class PersonalLoan
        {
            public string AccountNumber { get; set; }
            public string AccounHolderName { get; set; }
            public Loan LoanDetail { get; set; }
            public PersonalLoan(string accountNumber)
            {
                this.AccountNumber = accountNumber;
                this.AccounHolderName = "Sourav";
            }
        }

        public class Loan
        {
            public string AccountNumber { get; set; }
            public float LoanAmount { get; set; }
            public bool IsLoanApproved { get; set; }
            public Loan(string accountNumber)
            {
                Console.WriteLine("Loan loading started");
                this.AccountNumber = accountNumber;
                this.LoanAmount = 1000;
                this.IsLoanApproved = true;
                Console.WriteLine("Loan loading started");
            }
        }

        #endregion

        #region StreamReader

        //Streamreader and StreamWriter are classes of System.IO 
        //Used when we want to read or write character, Reader based data,
        //members of StreamReader are: close(), Read(), Readline().
        //members of Streamwriter are: close(), write(), writeline().
        public class StreamReadWrite
        {
            StreamReader sr = new StreamReader("C:Readme.txt");
            StreamWriter sw = new StreamWriter("C:Readme.txt");

        }

        #endregion

        #region Sealed Class

        sealed class SealedClass  // working  as no derive or inheritance used
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }

        class X  // not working as u cannot override or inherit a sealed class
        {
            protected virtual void F()
            {
                Console.WriteLine("X.F");
            }
            protected virtual void F2()
            {
                Console.WriteLine("X.F2");
            }
        }
        class Y : X
        {
            sealed protected override void F()
            {
                Console.WriteLine("Y.F");
            }
            protected override void F2()
            {
                Console.WriteLine("X.F3");
            }
        }
        class Z : Y
        {

            // Attempting to override F causes compiler error CS0239.  
            //   
            //protected override void F()
            //{
            //    Console.WriteLine("C.F");
            //}


            // Overriding F2 is allowed.   
            protected override void F2()
            {
                Console.WriteLine("Z.F2");
            }
        }

        sealed class SealedClassAdd
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }

        #endregion

        #region WhatisTheOutput
        public class empSal
        {
            public static int age = 40;
            public static int salary = 25000;

        }
        public class record : empSal
        {
            new public static int salary = 50000;
            static void Main(string[] args)
            {
                Console.WriteLine(empSal.age + "  " + empSal.salary + "  " + salary);
            }
        }


        class baseclass
        {
            public void func1() { }
            public virtual void func2() { }
            public virtual void func3() { }
        }
        class derivedclass : baseclass
        {
            new public void func1() { }
            public override void func2() { }
            public new void func3() { }
        }


        class sample
        {
            public sample()
            {
                Console.WriteLine("constructor 1 called");
            }
            public sample(int x)
            {
                int p = 2;
                int u;
                u = p + x;
                Console.WriteLine("constructor 2 called");
            }
        }

        class sampleQ2
        {
            int i;
            public sampleQ2(int x)
            {
                i = x;
                Console.WriteLine("Tech");
            }
        }
        class derived : sampleQ2
        {
            public derived(int x) : base(x)
            {
                Console.WriteLine("Beamers");
            }
        }

        class sampleQ3
        {
            int i;
            public sampleQ3(int num)
            {
                num = 12;
                int j = 12;
                int val = num * j;
                Console.WriteLine(val);
            }
        }
        class sample1 : sampleQ3
        {
            public sample1(int a) : base(a)
            {
                a = 13;
                int b = 13;
                Console.WriteLine(a + b);
            }
        }
        class sample2 : sample1
        {
            public sample2(int k) : base(k)
            {
                k = 24;
                int o = 6;
                Console.WriteLine(k / o);
            }
        }

        class sampleQ4
        {
            static sampleQ4()
            {
                int num = 8;
                Console.WriteLine(num);
            }
            public sampleQ4(int a)
            {
                int val = 10;
                Console.WriteLine(val);
            }
        }

        #endregion

        #region Threading
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");

            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        public static void CallToChildThreadDestroy()
        {
            try
            {
                Console.WriteLine("Child thread starts");

                // do some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("Thread Abort Exception");
                throw ex;
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        #endregion

        #region Delegate

        // Declare a delegate
        delegate double CalculateSimpleInterest(double p, double t, double r);
        static CalculateSimpleInterest SI = getTotalInterest;


        static double getTotalInterest(double p, double t, double r)
        {
            return (p * t * r) / 100;
        }


        public delegate string MyDel(string str);

        public class EventProgram
        {
            public event MyDel MyEvent;
            public EventProgram()
            {
                this.MyEvent += new MyDel(this.WelcomeUser);
            }
            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }
        }

        public delegate void MyDelegate(string var);

        public static void GetData(string Name)
        {

        }

        public static void GetDataDelegate(string Name)
        {
            var myName = Name + "GetDate : " + Name;
        }

        public static void GetDat_one(string Name)
        {
            var myName = Name + "GetDate_One : " + Name;
        }

        delegate void Printer();


        #endregion

        #region DepenedencyInjection
        public interface text
        {
            void print();
        }
        class format : text
        {
            public void print()
            {
                Console.WriteLine(" here is text format");
            }
        }

        // constructor injection
        public class constructorinjection
        {
            private text _text;
            public constructorinjection(text t1)
            {
                this._text = t1;
            }
            public void print()
            {
                _text.print();
            }
        }

        public interface Iset
        {
            void print();
        }
        public class servic : Iset
        {
            public void print()
            {
                Console.WriteLine("print........");
            }
        }
        public class client
        {
            private Iset _set;
            public void run(Iset serv)
            {
                this._set = serv;
                Console.WriteLine("start");
                this._set.print();
            }
        }

        #endregion

        #region AsyncAwait

        //if any process is blocked in a synchronous application, the entire application gets blocked and our application stops responding 
        //until the whole task completes.
        //Asynchronous programming is very helpful in this condition.The Application can continue with the other work that does not 
        //depend on the completion of the whole task

        //we are calling a ReadFile method to read the contents of a text file and get the length of the characters present in the text file.
        //In our sampleText.txt, file contains too many characters, so It will take a long time to read all the characters.
        //So we are using async programming to read all the contents from the file,
        //So it will not wait to get a return value from this method and execute the other lines of code 

        //Output : File reading is stating
        //         Other Work 1
        //         Other Work 1
        //         Other Work 1
        //         File reading is completed

        static async void CallMethod()
        {
            string filePath = "E:\\sampleFile.txt";
            Task<int> task = ReadFile(filePath);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int length = await task;
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously    
                // and returns them as one string.    
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }

        #endregion

        #region CoVariance & ContraVariance
        //One is a base class for class Two, whereas Two is a base class for Three.
        //A base class can hold a derived class, but the opposite is not possible.

        //With Covariance, you can pass a derived type where a base type is expected.
        //Co-variance can be used on array, interface, delegates, etc in C#.

        //Contra variance is for parameters.A method with the parameter of a base class is allowed to be assigned to a delegate 
        //it expects the parameter of a derived class with Contravariance.
        class One
        {
        }
        class Two : One
        {
        }
        class Three : Two
        {
        }

        #endregion

        #region UseofStaticKeyword

        public int myVar;  //a non-static field 
        public static int myVarStatic;

        #endregion

        #region PolymorphismExample
        public abstract class PolyEmployee
        {
            public virtual void LeaderName()
            {
            }
        }

        public class hrDepart : PolyEmployee
        {
            public override void LeaderName()
            {
                Console.WriteLine("Mr. jone");
            }
        }
        public class itDepart : PolyEmployee
        {
            public override void LeaderName()
            {
                Console.WriteLine("Mr. Tom");
            }
        }

        public class financeDepart : PolyEmployee
        {
            public override void LeaderName()
            {
                Console.WriteLine("Mr. Linus");
            }
        }

        #endregion

        #region AbstactClassExample
        public abstract class AbstractEmployess
        {
            //abstract method with no implementation    
            public abstract void displayData();
        }

        //derived class    
        public class test : AbstractEmployess
        {
            //abstract class method implementation    
            public override void displayData()
            {
                Console.WriteLine("Abstract class method");
            }
        }

        #endregion

        #region EncapsulationDemo

        public class EncapsulationDemo
        {
            private int _mark;
            public int Mark
            {
                get
                {
                    return _mark;
                }
                set
                {
                    if (_mark > 0)
                    {
                        _mark = value;
                    }
                    else
                    {
                        _mark = 0;
                    }
                }
            }
        }

        public class Aperture
        {
            public Aperture()
            {
                Aperture objAperture = new Aperture();

                objAperture.GetVolume();
            }
            protected double height;
            protected double width;
            protected double thickness;
            public double GetVolume()
            {
                Double volume = height * width * thickness;
                if (volume < 0)
                {
                    return 0;
                }
                return volume;
            }
        }

        #endregion

        #region PrivateConstructor
        class PrivateConst
        {
            //private constructor
            private PrivateConst()
            {
                PrivateConst objPrivateConst = new PrivateConst();// possible from Inside the class
                                                                  // Not Possible from outdide the class 
            }
        }

        #endregion

        #region Indexer
        class IndexedNames
        {
            private string[] namelist = new string[size];
            static public int size = 10;

            public IndexedNames()
            {
                for (int i = 0; i < size; i++)
                    namelist[i] = "N. A.";
            }
            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= size - 1)
                    {
                        tmp = namelist[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= size - 1)
                    {
                        namelist[index] = value;
                    }
                }
            }
        }

        #endregion

        #region Exception Handling
        public void ExceptionMethod()
        {
            throw new Exception("Original Exception occurred in ExceptionMethod");
        }

        #endregion

        #region Stucture

        //Structures are suitable to represent lightweight objects.
        //Structures can have methods and properties and are useful for defining types that act as user-defined primitives,
        //some Built in structures such as System.Drawing.Rectangle, System.Drawing.Point, and System.Drawing.Color.

        public struct Book
        {
            public string Title;
            public string Author;
            public decimal Price;
            public short Year;
        }

        #endregion

        static void FieldInvestigation(Type t)
        {
            Console.WriteLine("*********Fields*********");
            FieldInfo[] fld = t.GetFields();
            foreach (FieldInfo f in fld)
            {
                Console.WriteLine("-->{0}", f.Name);
            }
        }


        #region Avoid Null in C#
        public static string DisplayUpperString(string s)
        {
            string upper;
            if (s == null)
            {
                upper = null;
            }
            else
            {
                upper = s.ToUpper();
            }
            return upper;
        }


        #endregion

        #region Static and Dynamic

        public interface IRegister
        {
            //Register realted function    
        }
        public interface ILogin
        {
            //Login related function    
        }

        #region DynamicKywd
        public class DemoDynamic
        {
            dynamic Data = 12;
            public int Method(int A, int B)
            {
                return (A + B) * Data;
            }
        }

        #endregion

        class MyCollegeStatic
        {
            //static fields  
            public static string CollegeName;
            public static string Address;

            //static constructor  
            static MyCollegeStatic()
            {
                CollegeName = "ABC College of Technology";
                Address = "Hyderabad";
            }
        }


        //non-statcic data members  
        public string StudentName;
        public string Course;
        public void SetStudentDetails(string StuName, string Cou)
        {
            StudentName = StuName;
            Course = Cou;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine(StudentName + " - " + Course);
        }

        //static data members  
        public static string CollegeName = "ABC College of Technology";
        public static string CollegeAddress = "Hyderabad";

        //static methods  
        public static void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
        }

        class MyCollege
        {
            //static fields  
            public static string CollegeName;
            public static string Address;

            //static constructor  
            static MyCollege()
            {
                CollegeName = "ABC College of Technology";
                Address = "Hyderabad";
            }
        }


        #endregion

        #region LinkedList
        static void DLLCaller()
        {
            HelperDLL objHelper = new HelperDLL();
            DoubleLinkedList myLinkedList = new DoubleLinkedList();

            objHelper.InsertFront(myLinkedList, 10);
            objHelper.InsertFront(myLinkedList, 20);
            objHelper.InsertLast(myLinkedList, 100);
            objHelper.InsertBefore(myLinkedList.head.next.next, 30);
            objHelper.InsertAfter(myLinkedList.head.next.next, 40);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
            objHelper.ReverseLinkedList(myLinkedList);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
        }

        static void SLLCaller()
        {
            HelperSLL objHelper = new HelperSLL();
            SingleLinkedList myLinkedList = new SingleLinkedList();

            objHelper.InsertFront(myLinkedList, 2);
            objHelper.InsertLast(myLinkedList, 3);
            objHelper.InsertLast(myLinkedList, 4);
            objHelper.InsertLast(myLinkedList, 5);
            objHelper.InsertLast(myLinkedList, 6);
            objHelper.FindMiddle(myLinkedList);
            objHelper.InsertLast(myLinkedList, 25);
            objHelper.InsertAfter(myLinkedList.head.next.next, 30);
            objHelper.PrintList(myLinkedList);
            objHelper.ReverseLinkedList(myLinkedList);
            objHelper.DeleteNodebyKey(myLinkedList, 3);
            Console.WriteLine();
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
            objHelper.SearchLinkedList(myLinkedList, 25);
            objHelper.SearchLinkedList(myLinkedList, 40);
            objHelper.DeleteNodebyPosition(myLinkedList, 3);
            Console.WriteLine();
            objHelper.PrintList(myLinkedList);
            Console.ReadLine();
        }

        #endregion

        #region Solid Principles Example

        #region SingleResponsibility
        class Customer
        {
            private FileLogger obj = new FileLogger(); //After SRP
            public void Add()
            {
                try
                {
                    // Database & Bussiness Logic code goes here
                }
                catch (Exception ex)
                {
                    System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());  // Before SRP 
                    obj.Handle(ex.ToString()); // After SRP
                }
            }
        }
        class FileLogger
        {
            public void Handle(string error)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", error);
            }
        }

        #endregion

        #region OpenClosePrinciple 

        //Open For Extension and Closed for Modification
        public class Account
        {
            public decimal Interest { get; set; }
            public decimal Balance { get; set; }
            public decimal CalcInterest(string accType)
            {

                if (accType == "Regular") // savings
                {
                    Interest = (Balance * 4) / 100;
                    if (Balance < 1000) Interest -= (Balance * 2) / 100;
                    if (Balance < 50000) Interest += (Balance * 4) / 100;
                }
                else if (accType == "Salary") // salary savings
                {
                    Interest = (Balance * 5) / 100;
                }
                else if (accType == "Corporate") // Corporate
                {
                    Interest = (Balance * 3) / 100;
                }
                return Interest;
            }
        }

        interface IAccount
        {
            // members and function declaration, properties
            decimal Balance { get; set; }
            decimal CalcInterest();
        }

        //regular savings account 
        public class RegularSavingAccount : IAccount
        {
            public decimal Balance { get; set; } = 0;
            public decimal CalcInterest()
            {
                decimal Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;

                return Interest;
            }
        }

        //Salary savings account 
        public class SalarySavingAccount : IAccount
        {
            public decimal Balance { get; set; } = 0;
            public decimal CalcInterest()
            {
                decimal Interest = (Balance * 5) / 100;
                return Interest;
            }
        }
        //Corporate Account
        public class CorporateAccount : IAccount
        {
            public decimal Balance { get; set; } = 0;
            public decimal CalcInterest()
            {
                decimal Interest = (Balance * 3) / 100;
                return Interest;
            }
        }

        #endregion

        #region LiskovSubstituion

        //you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification. 
        //A derived class must be substitutable for its base class.
        public class SqlFile : IReadableSqlFile
        {
            public string FilePath { get; set; }
            public string FileText { get; set; }
            public string LoadText()
            {
                /* Code to read text from sql file */
                return "";
            }
            public string SaveText()
            {
                /* Code to save text into sql file */
                return "";
            }
        }
        public class SqlFileManager
        {
            public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
            {
                StringBuilder objStrBuilder = new StringBuilder();

                foreach (var objFile in aLstReadableFiles)
                {
                    objStrBuilder.Append(objFile.LoadText());
                }
                return objStrBuilder.ToString();
            }
        }

        //we may have a few read-only files in the application folder, so we need to restrict the flow whenever it tries to do a save on them.

        //We can do that by creating a "ReadOnlySqlFile" class that inherits the "SqlFile" class and we need to alter the SaveTextIntoFiles() 
        //by introducing a condition to prevent calling the SaveText() method on ReadOnlySqlFile instances.

        //we altered the SaveTextIntoFiles() method in the SqlFileManager class to determine whether or not the instance is of ReadOnlySqlFile 
        //to avoid the exception.We can't use this ReadOnlySqlFile class as a substitute for its parent without altering SqlFileManager code. 
        public class ReadOnlySqlFile : IReadableSqlFile
        {
            public string FilePath { get; set; }
            public string FileText { get; set; }
            public string LoadText()
            {
                /* Code to read text from sql file */
                return "";
            }
            public void SaveText()
            {
                /* Throw an exception when app flow tries to do save. */
                throw new IOException("Can't Save");
            }
        }

        public interface IReadableSqlFile
        {
            string LoadText();
        }
        public interface IWritableSqlFile
        {

        }

        #endregion

        #region InterfaceSegrigation

        //clients should not be forced to implement interfaces they don't use. Instead of one fat interface,
        //many small interfaces are preferred based on groups of methods, each one serving one submodule.

        //Like classes, each interface should have a specific purpose/responsibility(Like SRP). 
        //You shouldn't be forced to implement an interface when your object doesn't share that purpose.

        public interface ILead
        {
            void CreateSubTask();
            void AssignTask();
            void WorkOnTask();

        }
        public interface IProgrammer
        {
            void WorkOnTask();
        }
        public class Programmer : IProgrammer
        {
            public void WorkOnTask()
            {
                //code to implement to work on the Task.  
            }
        }
        public class Manager : ILead
        {
            public void AssignTask()
            {
                //Code to assign a task.  
            }
            public void CreateSubTask()
            {
                //Code to create a sub task.  
            }
            public void WorkOnTask()
            {
                throw new Exception("Manager can't work on Task");
            }
        }
        public class TeamLead : IProgrammer, ILead
        {
            public void AssignTask()
            {
                //Code to assign a Task  
            }
            public void CreateSubTask()
            {
                //Code to create a sub task from a task.  
            }
            public void WorkOnTask()
            {
                //code to implement to work on the Task.  
            }
        }

        #endregion

        #region DepenedencyInversion

        //Dependency Inversion Principle(DIP) states that high-level modules/classes should not depend on low-level modules/classes.
        //Abstractions should not depend upon details.Details should depend upon abstractions.
        //High-level modules/classes implement business rules or logic in a system (application). 
        //Low-level modules/classes deal with more detailed operations; in other words they may deal with writing information to databases 
        //or passing messages to the operating system or services.

        public interface ILogger
        {
            void LogMessage(string aString);
        }

        //Client wants to store this stack trace in a database if an IO exception occurs.
        //Here we need to add one more class that provides the functionality to log the 
        //stack trace into the database and an extra method in ExceptionLogger 
        public class DbLoggerDI : ILogger
        {
            public void LogMessage(string aMessage)
            {
                //Code to write message in database.  
            }
        }
        public class FileLoggerDI : ILogger
        {
            public void LogMessage(string aStackTrace)
            {
                //code to log stack trace into a file.  
            }
        }
        public class EventLogger : ILogger
        {
            public void LogMessage(string aMessage)
            {
                //Code to write message in system's event viewer.  
            }
        }

        //whenever the client wants to introduce a new logger, we need to alter ExceptionLogger by adding a new method.
        // If we continue doing this after some time then we will see a fat ExceptionLogger
        public class ExceptionLogger
        {
            private ILogger _logger;
            public ExceptionLogger(ILogger aLogger)
            {
                this._logger = aLogger;
            }
            public void LogException(Exception aException)
            {
                string strMessage = GetUserReadableMessage(aException);
                this._logger.LogMessage(strMessage);
            }
            private string GetUserReadableMessage(Exception aException)
            {
                string strMessage = string.Empty;
                //code to convert Exception's stack trace and message to user readable format.  
                return strMessage;
            }
        }

        //A client class exports data from many files to a database.
        public class DataExporter
        {
            public void ExportDataFromFile()
            {
                ExceptionLogger _exceptionLogger;
                try
                {
                    //code to export data from files to database.  
                }
                catch (IOException ex)
                {
                    _exceptionLogger = new ExceptionLogger(new DbLoggerDI());
                    _exceptionLogger.LogException(ex);
                }
                catch (SqlException ex)
                {
                    _exceptionLogger = new ExceptionLogger(new EventLogger());
                    _exceptionLogger.LogException(ex);
                }
                catch (Exception ex)
                {
                    _exceptionLogger = new ExceptionLogger(new FileLoggerDI());
                    _exceptionLogger.LogException(ex);
                }
            }
        }

        #endregion

        #endregion

        #region DesignPattern Examples

        #region Factory Pattern

        /// <summary>
        /// The 'Product' interface
        /// </summary>
        public interface IFactory
        {
            void Drive(int miles);
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        public class Scooter : IFactory
        {
            public void Drive(int miles)
            {
                Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
            }
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        public class Bike : IFactory
        {
            public void Drive(int miles)
            {
                Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
            }
        }

        /// <summary>
        /// The Creator Abstract Class
        /// </summary>
        public abstract class VehicleFactory
        {
            public abstract IFactory GetVehicle(string Vehicle);
        }

        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>
        public class ConcreteVehicleFactory : VehicleFactory
        {
            public override IFactory GetVehicle(string Vehicle)
            {
                switch (Vehicle)
                {
                    case "Scooter":
                        return new Scooter();
                    case "Bike":
                        return new Bike();
                    default:
                        throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
                }
            }
        }

        #endregion

        #region Singleton Patern

        //Ensures a class has only one instance and provides a global point of access to it.
        //A singleton is a class that only allows a single instance of itself to be created and usually gives simple access to that instance.
        //singletons don't allow any parameters to be specified when creating the instance since the second request of an instance 
        //with a different parameter could be problematic! 

        public sealed class Calculate
        {
            private Calculate()
            {
            }
            private static Calculate instance = null;
            public static Calculate Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Calculate();
                    }
                    return instance;
                }
            }
            public double ValueOne { get; set; }
            public double ValueTwo { get; set; }
            public double Addition()
            {
                return ValueOne + ValueTwo;
            }
            public double Subtraction()
            {
                return ValueOne - ValueTwo;
            }
            public double Multiplication()
            {
                return ValueOne * ValueTwo;
            }
            public double Division()
            {
                return ValueOne / ValueTwo;
            }
        }

        #endregion

        #endregion

        #region INTERVIEW QUESTIONS

        #region Derived class from Base class

        //Derived class object from base class

        class DerParent
        {
            DerChild objCh = new DerChild();
            public DerParent()
            {
                Console.WriteLine("Parent Class Constructor");
            }
        }
        class DerChild : DerParent
        {
            public DerChild()
            {
                Console.WriteLine("Child class Constructor");
            }
            //Parent objP = new Parent();
        }

        #endregion

        #region PrivateConstructor

        //Private constructor is constructor that is preceded by private access specifier. 
        //For example, below class has a private constructor.
        //No, object of a class having private constructor cannot be instantiated from outside of the class. 

        class PrivateCons
        {
            //private constructor
            private PrivateCons()
            {

            }
        }

        #endregion

        #region Immutable string

        //Since String is a reference type y will
        //point to the same location where msg is
        //pointing to

        //Note that value of string msg is not copied
        //But reference of msg string as String data
        //Type is reference type.
        public static void Display1(String y)
        {
            //It will print the original string
            //Y is having the same reference as msg variable.
            Console.WriteLine(y);
            //but If we try to change the  value of y 
            //it will create another memory and assign "My World"
            //string and it will not modify the memory msg variable
            //is pointing to in Main program.
            y = "My World";
            Console.WriteLine(y);
        }

        //Since String is a reference type y will
        //point to the same location where x is
        //pointing to
        private static void Display2(String y)
        {
            Console.WriteLine(y);
        }

        #endregion

        #region Method Hiding
        class Base
        {
            public void show()
            {
                Console.WriteLine("Base...");
            }
        }
        class Derived : Base
        {
            new public void show()
            {
                Console.WriteLine("Derived...");
            }
        }

        #endregion

        #region 2 Interfaces with same method

        //Interfaces ILoanCustomer & IBankCustomer
        //have same method name. That will be implemented
        //Explicitely in Customer class
        interface ILoanCustomer
        {
            void GetCostomerInfo();
        }
        interface IBankCustomer
        {
            void GetCostomerInfo();
        }


        class Customer2Interfaces : ILoanCustomer, IBankCustomer
        {
            //Explicit implementation of ILoanCustomer interface
            void ILoanCustomer.GetCostomerInfo()
            {
                Console.WriteLine("Loan Customer ...");

            }
            //Explicit IBankCustomer of ILoanCustomer interface
            void IBankCustomer.GetCostomerInfo()
            {
                Console.WriteLine("Bank Customer ...");

            }
        }

        #endregion

        #region Multiple interface inheritance

        //Create Ist interface
        interface ICreditCard
        {
            void validateCard();
        }
        //Create 2nd interface
        interface ITransaction
        {
            void startTransaction();
        }

        //Mastor credit card class will inherit multiple interfaces
        class MastroCreditCard : ICreditCard, ITransaction
        {

            public void validateCard()
            {
                Console.WriteLine("Validating Credit Card");
            }
            public void startTransaction()
            {
                Console.WriteLine("Starting transaction");
            }
            public void transactionStatus()
            {
                Console.WriteLine("Transaction completed");
            }
        }

        #endregion

        #region Same result using Interface or Abstract Class

        //Interface
        interface IShape
        {
            void draw();

        }

        //Derived
        class InterfCircle : IShape
        {
            public void draw()
            {
                Console.WriteLine("Drawing Circle");
            }
        }

        //Test class
        class ShapeGame
        {
            public void drawShape(IShape shape)
            {
                shape.draw();
            }
        }

        #endregion

        #region Delegate With Ex
        public static int sum(int a, int b)
        {
            return a + b;
        }

        #endregion

        #region Using STMNT Example
        class SystemResource : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("C");
            }

        }
        #endregion

        #region Deligate
        public class RectangleDeli
        {
            public void Area(double Width, double Height)
            {
                Console.WriteLine(@"Area is {0}", (Width * Height));
            }
            public void Perimeter(double Width, double Height)
            {
                Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
            }
        }

        #endregion

        #region Square every digit of a number
        public static int SquareDigits(int n)
        {
            var val = n.ToString();

            var result = "";

            for (var i = 0; i < val.Length; i++)
            {
                char c = val[i];
                int num = int.Parse(c.ToString());
                result += (num * num);
            }
            return int.Parse(result);
        }
        #endregion

        #region SwapTwoNumbers
        public static string SwapTwoNumbers(int a, int b)
        {
            string before = $"Before: a = {a}, b = {b}; ";
            int temp;

            temp = b;
            b = a;
            a = temp;

            string after = $"After: a = {a}, b = {b}";
            return before + after;
        }

        #endregion

        #region IfGreaterThanThirdOne
        static bool IfGreaterThanThirdOne(int[] arr)
        {
            return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
        }
        #endregion

        #region IfNumberContains3
        public static bool IfNumberContains3(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 3)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        #endregion

        #region PositiveNegativeOrZero
        static string PositiveNegativeOrZero(double num)
        {
            if (num > 0.0)
            {
                return "Positive";
            }
            else if (num < 0.0)
            {
                return "Negative";
            }

            return "Zero";
        }

        #endregion

        static void DrawParallelogram()
        {
            for (var j = 0; j < 5; j++)
            {
                for (var k = 0; k < 5 - j; k++)
                {
                    Console.Write(" ");
                }
                for (var m = 0; m < 15; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static string ExtractString(string word)
        {
            string extractedWord = string.Empty;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] == '#' && word[i + 1] == '#')
                {
                    for (int j = i + 2; j <= word.Length - 1; j++)
                    {
                        if (word[j] == '#' && word[j + 1] == '#')
                        {
                            return extractedWord;
                        }
                        extractedWord += word[j];
                    }
                }
            }

            return string.Empty;
        }

        static string FullSequenceOfLetters(string word)
        {
            string fullSequence = string.Empty;
            for (int i = word[0], j = 0; i <= word[1]; i++, j++)
            {
                fullSequence += (char)(word[0] + j);
            }

            return fullSequence;
        }

        static int LongestStrictlyIncreasingSequence(int[] array)
        {
            int tempLongest = 0;
            int longest = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] > array[i])
                {
                    tempLongest++;
                }
                else
                {
                    tempLongest = 0;
                }

                if (tempLongest > longest)
                {
                    longest = tempLongest;
                }
            }

            return longest;
        }

        static int HowManyOccurrences(string str, string subStr)
        {
            int found;
            int total = 0;
            for (int i = 0; i < str.Length; i++)
            {
                found = str.IndexOf(subStr, i);

                if (found > -1)
                {
                    total++;
                    i = found;
                }
            }

            return total;
        }

        static bool IsPalindromeRecursion(string str)
        {
            if (str.Length == 1 || (str.Length == 2 && str[0] == str[1]))
            {
                return true;
            }
            else if (str.Length > 1)
            {
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }

                return IsPalindromeRecursion(str.Substring(1, str.Length - 2));
            }

            return false;
        }

        static int MinimumElement(int[] arr, int size)
        {
            if (size == 1)
            {
                return arr[0];
            }

            return arr[size - 1] < MinimumElement(arr, size - 1) ? arr[size - 1] : MinimumElement(arr, size - 1);
        }

        static int ToThePowerOfRecursion(int b, int exp)
        {
            return exp == 0 ? 1 : exp > 1 ? b * ToThePowerOfRecursion(b, exp - 1) : b;
        }

        public static bool EveryWordInTheString(string word)
        {
            Regex regex = new Regex(@"^([A-Z]\w*\s*)+\W*$");
            Match match = regex.Match(word);

            return match.Success;
        }

        public static string DecimalDigitInformation(string word)
        {
            Regex regex = new Regex(@"\d");
            Match match = regex.Match(word);

            return match.Success ? $"Digit {match.Value} at position {match.Index}" : $"No digit found!";
        }



        #endregion

        static void Main(string[] args, Type t)
        {


            #region call a global method

            Employee GlobalMethod = new Employee();
            GlobalMethod.fullThrottle();

            #endregion

            #region Calling Methods

            // MethodAccessException call with optional parameter
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");

            #endregion

            #region Inheritance Example

            Employee Empl = new Employee();

            Empl.IDEmpl = "1";
            Empl.NameEmpl = "Anbu";
            Console.WriteLine("ID = " + Empl.IDEmpl);
            Console.WriteLine("Name = " + Empl.NameEmpl);

            ProgrammerEmpl p1Empl = new ProgrammerEmpl();
            Console.WriteLine("Salary: " + p1Empl.salaryEmpl);
            Console.WriteLine("Bonus: " + p1Empl.bonus);

            #endregion

            #region Passby Value & ref

            //Passing a Value Type parameter to a method  means passing a copy of the variable to the method.
            //So the changes made to the parameter inside of the called method will not have an effect on the original data stored 

            int PassByValue = 100;
            Console.WriteLine(PassByValue);
            ChangeValue(PassByValue);
            Console.WriteLine(PassByValue);

            //using the ref keyword, we can pass parameters reference-type and it’s mandatory to initialize the variable value 
            //before we pass it as an argument to the method

            int PassByRef = 10;
            Console.WriteLine("Variable Value Before Calling the Method: {0}", PassByRef);
            Multiplication(ref PassByRef);
            Console.WriteLine("Variable Value After Calling the Method: {0}", PassByRef);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();

            #endregion

            #region GetSet

            //The get method returns the value of the variable name.
            //The set method assigns a value to the name variable. 
            //The value keyword represents the value we assign to the property

            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            GetSetExample objGetSetExample = new GetSetExample();
            Console.WriteLine(objGetSetExample.GetsetMethod());// Output for GetSet Eg

            #endregion

            #region AccessModifiers

            //internal: The type or member can be accessed by any code in the same assembly, but not from another assembly
            //protected internal: The type or member can be accessed by any code in the assembly in which it's declared, 
            //or from within a derived class in another assembly

            PhoneMake PhMake = new PhoneMake();

            //Console.WriteLine(PhMake.PhoneModelPrivate); // In accessible due to Protection Level  PRIVATE
            Console.WriteLine(PhMake.PhoneModelPublic);
            Console.WriteLine(PhMake.Location_Internal); // Internal variables work within the Same assembly
            Console.WriteLine(PhMake.Age_ProtectedInternal); //Access is limited to the current assembly or types derived from the containing class
                                                             //Console.WriteLine(PhMake.numberProtected);  // In accessible due to Protection Level  PROTECTED

            #endregion

            #region Generics

            // A generic collection is strongly typed  meaning that you can only put one type of object into it.
            // As we know different collection in C# like Array, ArrayList,HashTable etc. 
            // Use generic types to maximize code reuse, type safety, and performance.
            //The most common use of generics is to create collection classes. 
            //You can create your own generic interfaces, classes, methods, events and delegates.

            //instantiate generic with Integer  
            TestClass<int> intObj = new TestClass<int>();

            //adding integer values into collection  
            intObj.Add(1);
            intObj.Add(2);
            intObj.Add(3);     //No boxing  
            intObj.Add(4);
            intObj.Add(5);

            //displaying values  
            for (int iGeneric = 0; iGeneric < 5; iGeneric++)
            {
                Console.WriteLine(intObj[iGeneric]);   //No unboxing  
            }
            Console.ReadKey();


            #region  StronglyTyped

            string resultGen = string.Empty;

            // Strongly typed example
            //1 and "1" are not same

            //var answer = 1 * "1"; // you cannot do this

            #endregion

            Check objCheck = new Check();
            bool resultCheck = objCheck.Compare(1, 4);
            Console.Write(resultCheck);

            Check<int> objGeneric = new Check<int>();
            bool checkCompare = objCheck.Compare(2, 6);
            Console.WriteLine(checkCompare);

            _methodDictionary = new Dictionary<string, string>();
            _methodDictionary = GetMethodsDictionary();

            var type = typeof(StudentFunction);
            var studentFunctionInstance = Activator.CreateInstance(type);

            var testString = "Hello [GetName], your university name is [GetUniversity] and roll is [GetRoll]";
            var match = Regex.Matches(testString, @"\[([A-Za-z0-9\-]+)]", RegexOptions.IgnoreCase);
            foreach (var v in match)
            {
                var originalString = v.ToString();
                var GenricsX = v.ToString();
                GenricsX = GenricsX.Replace("[", "");
                GenricsX = GenricsX.Replace("]", "");
                GenricsX = _methodDictionary[GenricsX];

                var toInvoke = type.GetMethod(GenricsX);
                var GenericsResult = toInvoke.Invoke(studentFunctionInstance, null);
                testString = testString.Replace(originalString, resultGen.ToString());
            }

            Console.WriteLine(testString);

            #endregion

            #region Ternary Operators

            // Ternary operator must always return a value so it should be assigned with a variable  
            // Also, Statements cannot be executed inside ternary operator  
            // Gives a compiler error as "Only assignment, call, increment, decrement, and new object expressions can be used as statement"  

            Employee.Compare(66, 579);
            Console.ReadKey();

            #endregion

            #region EnumEg

            //enum is a value type data type.
            //enum is used to declare a list of named integer constants.
            //It can be defined using the enum keyword directly inside a namespace, class, or structure.
            //enum is used to give a name to each constant so that the constant integer can be referred using its name.
            //Use enums when you have values that you know aren't going to change like monthdays,days,colors,deck of cards

            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            Level myVarEnum = Level.Medium;

            switch (myVarEnum)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }

            #endregion

            #region Interfaces

            //Like abstract classes interfaces cannot be used to create objects           
            //Interface methods do not have a body 
            //On implementation of an interface, you must override all of its methods
            //Interfaces can contain properties and methods, but not fields/variables
            //Interface members are by default abstract and public
            //An interface cannot contain a constructor(as it cannot be used to create objects)

            InterfacePig myInterfacePig = new InterfacePig();  // Create a obj for the class used by interface
            myInterfacePig.animalSound();

            //An implicit interface implementation is where you have a method with the same signature of the interface.
            TestClass objImplicit = new TestClass();
            objImplicit.TestMethod(); //call implicitely implemented method  

            //An explicit interface implementation is where you explicitly declare which interface the method belongs to.
            ITest objInterface = new TestClass();
            objInterface.TestMethod();

            #endregion

            #region InterfaceWithConflictingNames

            testInterface1 obj1ConfName = new Abc();
            testInterface1 obj2ConfName = new Abc();
            obj1ConfName.Show();
            obj2ConfName.Show();
            Console.ReadLine();

            #endregion

            #region AsIsOPerators

            //The "is" operator is used to check whether the run-time type of an object is compatible with a given type or not.
            //we use the "is" operator to verify that the type of an object is what we expect it to be.

            //The "as" operator is used to perform conversions between compatible types.Actually,
            //the "as" operator fulfills a similar role like "is" but in a slightly truncated manner.

            Class1 c1AsIS = new Class1();
            Class2 c2AsIs = new Class2();
            Test(c1AsIS);
            Test(c2AsIs);
            Test("Passing String Value instead of class");
            Console.ReadKey();

            object[] myObjects = new object[6];
            myObjects[0] = new Class1();
            myObjects[1] = new Class2();
            myObjects[2] = "string";
            myObjects[3] = 32;
            myObjects[4] = null;
            for (int iAsIs = 0; iAsIs < myObjects.Length; ++iAsIs)
            {
                string s = myObjects[iAsIs] as string;
                Console.Write("{0}:", iAsIs);
                if (s != null)
                {
                    Console.WriteLine("'" + s + "'");
                }

                else
                {
                    Console.WriteLine("not a string");
                }
            }
            Console.ReadKey();

            #endregion

            #region Abstract class [AbstractBaseclas]
            //The word abstract means a concept or an idea not associated with any specific instance.
            //In programming we apply the same meaning of abstraction by making classes not associated with any specific instance.
            //Abstraction is done when we need to only inherit from a certain class, and not need to instantiate objects of that class. 
            //In such case the base class can be regarded as "Incomplete". Such classes are known as an "Abstract Base Class".

            dog mydog = new dog();
            animalAbstractBaseclass thePet = mydog;
            thePet.eat();
            mydog.sound();

            //Finally we created an Object 'mydog' of class dog, but we didn't instantiate any object of Abstract Base Class 'animal'.

            #endregion

            #region EncapsulationEg

            //We can protect the private data from the outside world.Here we use two separate methods to assign and get the required data.

            Department dEncap = new Department();
            dEncap.SetDepartname("ELECTRONICS");
            Console.WriteLine("The Department is :" + dEncap.GetDepartname());

            //In the above example we can't access the private data departname from an object instance. 
            //We manipulate the data only using those two methods.

            #endregion

            #region OverrideExtensionMtd_Tostring

            //Every class or struct in C# implicitly inherits the Object class.So every object in C# gets the ToString method,
            //which returns a string representation of that object. 
            //Eg: All variables of type int have a ToString method, which enables them to return their contents as a string:

            EmployeeTostringOverride empOverrideTostring = new EmployeeTostringOverride() { EmpId = 100, EmpName = "Pradeep", DeptName = "Computer Science" };
            Console.WriteLine(empOverrideTostring.ToString());

            #endregion

            #region FunctionRtnManyValues

            int MultipleRtnA = 10, MultipleRtnB = 20, max = 0;
            int min = MultipleReturns(MultipleRtnA, MultipleRtnB, ref max);

            Console.WriteLine("Minimum Value: " + min);
            Console.WriteLine("Maximum Value: " + max);


            int aMultipleRtn = 10, bMultipleRtn = 20;
            int[] minMax = MultipleReturnsWithArray(aMultipleRtn, bMultipleRtn);
            Console.WriteLine("Minimum Value: " + minMax[1]);
            Console.WriteLine("Maximum Value: " + minMax[0]);

            #endregion

            #region OutAndRef

            int refI = 1;
            Console.WriteLine("Previous value of integer i:" + refI.ToString());
            string test = RefExample(ref refI);
            Console.WriteLine("Current value of integer i:" + refI.ToString());

            int Outi = 0;
            Console.WriteLine("Previous value of integer i:" + Outi.ToString());
            string OutVal = OutExample(out Outi);
            Console.WriteLine("Current value of integer i:" + Outi.ToString());

            #endregion

            #region Prefix & Postix

            //The increment operator ++ if used as prefix on a variable, the value of variable gets incremented by 1.
            //After that the value is returned unlike Postfix operator. It is called Prefix increment operator. 
            //In the same way the prefix decrement operator works but it decrements by 1

            int aPrefix, bPrefix;
            aPrefix = 50;
            Console.WriteLine(++aPrefix);

            bPrefix = aPrefix;
            Console.WriteLine(aPrefix);
            Console.WriteLine(bPrefix);

            //The increment operator ++ if used as postfix on a variable,value of variable is returned and then gets incremented by 1
            //It is called Postfix increment operator. In the same way the decrement operator works but it decrements by 1

            int aPostfix, bPostfix;
            aPostfix = 10;
            Console.WriteLine(aPostfix++);

            bPostfix = aPostfix;
            Console.WriteLine(aPostfix);
            Console.WriteLine(bPostfix);

            #endregion

            #region BitWise Operations

            //Bitwise operator works on bits and performs bit by bit operation.In Bitwise right shift operator the value of the left
            //operand is moved right by the number of bits specified by the right operand.
            //operand is moved right by the number of bits specified by the right operand.


            int aBitwise = 60;    /* 60 = 0011 1100 */
            int bbitwise = 0;
            int cbitwise = 0;
            cbitwise = aBitwise >> 2;    /* 15 = 0000 1111 */
            Console.WriteLine("Value of b is {0}", bbitwise);
            Console.ReadLine();

            // Bitwise AND Operator
            cbitwise = aBitwise & bbitwise; /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - Value of c is {0}", cbitwise);
            // Bitwise OR Operator
            cbitwise = aBitwise | bbitwise; /* 61 = 0011 1101 */
            Console.WriteLine("Line 2 - Value of c is {0}", cbitwise);
            // Bitwise XOR Operator
            cbitwise = aBitwise ^ bbitwise; /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - Value of c is {0}", cbitwise);
            // Bitwise Complement Operator
            cbitwise = ~aBitwise; /*-61 = 1100 0011 */
            Console.WriteLine("Line 4 - Value of c is {0}", cbitwise);
            // Bitwise Left Shift Operator
            cbitwise = aBitwise << 2; /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - Value of c is {0}", cbitwise);
            // Bitwise Right Shift Operator
            cbitwise = aBitwise >> 2; /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - Value of c is {0}", cbitwise);
            Console.ReadLine();

            byte varA = 10;// binary equivalent for 10 is 01010
            byte varB = 20;// binary equivalent for 20 is 10100
            long resultShift = varA | varB; // OR operation result should be 11110
                                            //so the result will contain 30 in decimal
            Console.WriteLine("{0} OR {1} Result :{2}", varA, varB, resultShift);
            varA = 10;// binary equivalent for 10 is 01010
            varB = 10;// binary equivalent for 10 is 01010
            resultShift = varA | varB; // OR operation result should be 01010
                                       //so the result will contain 10 in decimal
            Console.WriteLine("{0} OR {1} Result : {2}", varA, varB, resultShift);


            byte varAShift = 10;// binary equivalent for 10 is 01010
            resultShift = varA >> 1; // Right Shift operation result should be 0101
                                     //so the result will contain 5 in decimal
            Console.WriteLine("{0} is Right Shifted to 1 position Result :{1}", varAShift, resultShift);

            #endregion

            #region RecursionFunction

            //A recursive function is a function that calls itself.
            //A function that calls another function is normal but when a function calls itself then that is a recursive function. .

            #region WithoutRec

            Console.WriteLine("Please Enter a Number");
            int numberRec = Convert.ToInt32(Console.ReadLine());

            //invoke the static method    
            double factorial = Factorial(numberRec);

            //print the factorial result    
            Console.WriteLine("factorial of" + numberRec + "=" + factorial.ToString());

            #endregion

            #region WithRec

            Console.WriteLine("Please Enter a Number");
            int numberRecur = Convert.ToInt32(Console.ReadLine());

            double factorialRec = FactorialRec(numberRecur);
            Console.WriteLine("factorial of" + numberRecur + "=" + factorial.ToString());

            #endregion

            #endregion

            #region INTERVIEW QUESTIONS

            DerChild objC = new DerChild(); //Derived class object from base class
                                            //PrivateCons obj = new PrivateCons();//Error cannot access private constructor

            #region Advantage of immutable string in C# 

            //The main() method has a String msg = “Hello World”; and will call the display1() method and then the display2() method.
            //The display1() method will read the string and modify the string to “My World”.
            //The display2() method must read the original “Hello World” string, and not the string modified by display1() method.
            //Since, C# string is immutable, that is it cannot be modified, hence, the string modified by the display1() method will not be reflected in main() function. And display2() method will read the original string.

            //Hence, original data is safe!!!

            String msg = "Hello World";

            //Display1 method will read the string and modify it
            Display1(msg);

            //From here below program will read original
            //string i.e. "Hello World". as string is immutable
            //and cannot be changed by Display1 method.

            Console.WriteLine(msg);//print original string.

            //Display2 method will also read original string.
            Display2(msg);

            #endregion

            #region Method Hiding

            Derived MethodHiding = new Derived();
            MethodHiding.show();
            #endregion

            #region 2 Interfaces with Same Method
            IBankCustomer bc = new Customer2Interfaces();
            bc.GetCostomerInfo();

            ILoanCustomer lc = new Customer2Interfaces();
            lc.GetCostomerInfo();

            #endregion

            #region Multiple interface inheritance 

            MastroCreditCard card = new MastroCreditCard();
            card.validateCard();
            card.startTransaction();
            card.transactionStatus();

            #endregion

            #region Same result using Interface or Abstract Class

            IShape IntrAbscircle = new InterfCircle();
            ShapeGame g = new ShapeGame();
            g.drawShape(IntrAbscircle);

            #endregion

            #region MulWithOutStarOperator
            int xMul = 0, yMul = 0;
            int valueMul = 0;
            for (int z = 1; z <= yMul; z++)
            {
                valueMul = valueMul + xMul;
            }

            #endregion

            #region FindOutput

            int Outputx = 0;
            int Outputy = 0;

            for (short z = 0; z < 3; z++)
            {
                if ((++Outputx > 1) || (++Outputy > 1))
                {
                    Outputx++;
                }
            }
            Console.WriteLine(Outputx + "" + Outputy);


            int OPi = (byte)+(char)-(int)+(long)-1;
            Console.WriteLine(OPi);

            int FindOPi = 13;
            int FindOPj = 14;
            FindOPi = --FindOPi - FindOPi--;
            FindOPj = ++FindOPj + FindOPj++;
            Console.WriteLine(FindOPi + FindOPj);

            #endregion

            #region Using STMNT
            using (SystemResource res = new SystemResource())
            {
                Console.WriteLine("A");
            }
            Console.WriteLine("B");
            #endregion

            #region Deligate
            RectangleDeli rect = new RectangleDeli();
            rect.Area(23.45, 67.89);
            rect.Perimeter(23.45, 67.89);
            Console.ReadKey();
            #endregion

            #region Palindrome
            int n, r, numPali = 0, dem;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            dem = n;
            while (n > 0)
            {
                r = n % 10;
                numPali = (numPali * 10) + r;
                n = n / 10;
            }
            if (dem == numPali)
            {
                Console.Write("Number is Palindrome.");
            }
            else
            {
                Console.Write("Number is not Palindrome");
            }

            #endregion

            #region Reverse a Sentence

            string strRevSen = string.Empty;
            int iRevSen;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = strRevSen.Length - 1;
            int End = strRevSen.Length - 1;

            while (Start > 0)
            {
                if (strRevSen[Start] == ' ')
                {
                    iRevSen = Start + 1;
                    while (iRevSen <= End)
                    {
                        reverseSentence.Append(strRevSen[iRevSen]);
                        iRevSen++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (iRevSen = 0; iRevSen <= End; iRevSen++)
            {
                reverseSentence.Append(strRevSen[iRevSen]);
            }
            Console.WriteLine(reverseSentence.ToString());

            #endregion

            #region Dayofweek
            // Assume the current culture is en-US.
            // Create a DateTime for the first of May, 2003.
            DateTime dt = new DateTime(2003, 5, 1);
            Console.WriteLine("Is Thursday the day of the week for {0:d}?: {1}",
                               dt, dt.DayOfWeek == DayOfWeek.Thursday);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);

            #endregion

            #region Reverse a string
            string strRev = string.Empty; ;
            char[] charArray = strRev.ToCharArray();
            for (int istr = 0, jstr = strRev.Length - 1; istr < jstr; istr++, jstr--)
            {
                charArray[istr] = strRev[jstr];
                charArray[jstr] = strRev[istr];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
            #endregion

            #region Remove duplicate
            string strRemDup = string.Empty;
            string resultRemDup = string.Empty;

            for (int iRemDup = 0; iRemDup < strRemDup.Length; iRemDup++)
            {
                if (!resultRemDup.Contains(strRemDup[iRemDup]))
                {
                    resultRemDup += strRemDup[iRemDup];
                }
            }
            Console.WriteLine(resultRemDup);

            #endregion

            #region Left circular rotation
            int[] array = new int[10];
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            #endregion

            #region Right circular rotation

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            int sizeRc = array.Length;
            int tempRc = 0;
            for (int j = 0; j < size - 1; j++)
            {
                tempRc = array[0];
                array[0] = array[j + 1];
                array[j + 1] = tempRc;
            }
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            int number = 0;
            int f_0 = 0;
            int f_1 = 1;
            int sum = 0;
            Console.Write("{0} {1} ", f_0, f_1);
            for (int iFibi = 2; iFibi < number; iFibi++)
            {
                sum = f_0 + f_1;
                f_0 = f_1;
                f_1 = sum;
                int value = f_0 + f_1;
                Console.Write("{0} ", value);
            }

            #endregion

            #region SwapNumbers
            Console.WriteLine(SwapTwoNumbers(23, 15));      // Before: a = 23, b = 15; After: a = 15, b = 23
            Console.WriteLine(SwapTwoNumbers(-123, 999));   // Before: a = -123, b = 999; After: a = 999, b = -123
            Console.WriteLine(SwapTwoNumbers(0, 333));      // Before: a = 0, b = 333; After: a = 333, b = 0
            #endregion

            #region GreaterThanThird
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 8, 20 }));      // False
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));     // True
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { -15, -25, 100 })); // True
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 11, 15, 166 }));   // False
            #endregion

            #region IfNumberContains
            Console.WriteLine(IfNumberContains3(5384562)); // true
            Console.WriteLine(IfNumberContains3(0));       // false
            Console.WriteLine(IfNumberContains3(390462));  // true
            #endregion

            #region PostiveNegativeZero
            Console.WriteLine(PositiveNegativeOrZero(3.14)); // Positive
            Console.WriteLine(PositiveNegativeOrZero(0.0)); // Zero
            Console.WriteLine(PositiveNegativeOrZero(-200.003)); // Negative
            #endregion

            DrawParallelogram();

            Console.WriteLine(ExtractString("kFp##jFoRj##pL")); // jFoRj
            Console.WriteLine(ExtractString("abc##def"));       // /empty string/
            Console.WriteLine(ExtractString("##123456789##"));  // 123456789
            Console.WriteLine(ExtractString("no####thing"));    // /empty string/
            Console.WriteLine(ExtractString("empty"));          // /empty string/

            Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 4, 7, 2, 6, 4, 5, 6, 7, 8, 0, 7, 1, 2, 3 })); // 4
            Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 })); // 1
            Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 2, 3, 4, 5, 6, 7, 8 })); // 6
            Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 1, 1, 1, 1, 1, })); // 0

            Console.WriteLine(HowManyOccurrences("He is a good boy, he would never do that!", "he"));           // 1
            Console.WriteLine(HowManyOccurrences("104 593 00-930 720193", "93"));                               // 3
            Console.WriteLine(HowManyOccurrences("xyz", "a"));

            Console.WriteLine(IsPalindromeRecursion("aa"));        // True
            Console.WriteLine(IsPalindromeRecursion("dad"));       // True
            Console.WriteLine(IsPalindromeRecursion("apple"));     // False
            Console.WriteLine(IsPalindromeRecursion("deleveled")); // True
            Console.WriteLine(IsPalindromeRecursion(""));          // False
            Console.WriteLine(IsPalindromeRecursion("hannah"));    // True
            Console.WriteLine(IsPalindromeRecursion("X"));         // True

            Console.WriteLine(MinimumElement(new int[] { 7, 2, 9, 5, 4 }, 5));                  // 2
            Console.WriteLine(MinimumElement(new int[] { -45, -6, 39, 96, -20, 0, -100 }, 7));  // -100
            Console.WriteLine(MinimumElement(new int[] { 830, 905, 999, 831, 920, 900 }, 6));   // 830


            Console.WriteLine(ToThePowerOfRecursion(10, 0)); // 1
            Console.WriteLine(ToThePowerOfRecursion(3, 7));  // 2187
            Console.WriteLine(ToThePowerOfRecursion(2, 10)); // 1024

            Console.WriteLine(EveryWordInTheString("I Love You"));                    // True
            Console.WriteLine(EveryWordInTheString("Greater Than 9"));                // False
            Console.WriteLine(EveryWordInTheString("Pig And Horse!!!"));              // True
            Console.WriteLine(EveryWordInTheString("Make   Some      Whitespaces?")); // True
            Console.WriteLine(EveryWordInTheString("As Fit As a Fiddle."));           // False

            Console.WriteLine(DecimalDigitInformation("The 7 is the digit!"));    // Digit 7 at position 4
            Console.WriteLine(DecimalDigitInformation("Hamster and lion"));       // No digit found!
            Console.WriteLine(DecimalDigitInformation("1st"));                    // Digit 1 at position 0

            #region DaysInaWeek
            var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
            foreach (var dayInWeek in daysNames)
            {
                Console.Write($"{dayInWeek} "); // Sunday Monday Tuesday Wednesday Thursday Friday Saturday
            }

            #endregion

            #region TransposeAnArray

            var arrayDay = new int[][] {new int[]{ 1, 2, 3, 4, 5 },
                                     new int[]{ 6, 7, 8, 9, 10 },
                                     new int[]{ 11, 12, 13, 14, 15 },
                                     new int[]{ 16, 17, 18, 19, 20 },
                                     new int[]{ 21, 22, 23, 24, 25 }};
            var transposedArray = Enumerable.Range(0, arrayDay.Length).Select(xDay => arrayDay.Select(yDay => yDay[xDay]));

            foreach (var row in transposedArray)
            {
                foreach (var numberTranspose in row)
                {
                    Console.Write(numberTranspose + " ");
                }
                Console.WriteLine();
            }

            #endregion

            string str = "49fjs492jfJs94KfoedK0iejksKdsj3";
            var mostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
            Console.Write(mostFrequentCharacter);

            #region SplitString

            // Taking a string 
            string strSplit = "Geeks, For Geeks";

            String[] spearator = { "s, ", "For" };
            Int32 count = 2;

            // using the method 
            String[] strlist = strSplit.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Split with multiple separators");
            // Split with multiple separators  
            string multiCharString = "Mahesh..Chand, Henry\n He\t, Chris-Love, Raj..Beniwal, Praveen-Kumar";
            // Split authors separated by a comma followed by space  
            string[] multiArray = multiCharString.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string author in multiArray)
            {
                if (author.Trim() != "")
                    Console.WriteLine(author);
            }

            #endregion

            #region RegexFind

            string[] languages = { "C#", "Python", "Java" };
            foreach (string s in languages)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(s, "C#"))
                {
                    Console.WriteLine("Match found");
                }

            }

            #endregion



            //            Dictionary,
            //Returns an error if the key does not exist
            //No boxing and unboxing
            //Faster than a Hash table
            //Hashtable,
            //Returns NULL even if the key does not exist
            //Requires boxing and unboxing
            //Slower than a Dictionary

            //Singleton Design pattern

            //• Standard Singleton Implementation
            //• Early Instance Creation
            //• Double Checked Locking
            //• Using Generics
            //• Fully Lazy Instantiation
            //• Using Lazy type



            //            .Result, .GetAwaiter().GetResult(), WaitAll(), and WaitAny() (When working with Tasks)
            //Dispatcher.Invoke()(When working in WPF)
            //Join()(When working with Threads)
            //lock statements(In all cases)
            //WaitOne() methods(When working with AutoResetEvent / EventWaitHandle / Mutex / Semaphore)


            #endregion

            #region UseofStaticKywd

            //myVar is a non -static field so to use this field we first need to create the object of that class. 
            //static data is shared among all the objects of that class. 
            //for all the objects of a class,there will be 1 copy ofstatic data.

            //Non Static Field We need  Create obj 
            //Static Field No obj is needed

            Employee StaticMtd = new Employee();  //a object of class  
            StaticMtd.myVar = 10;
            Console.WriteLine(StaticMtd.myVar);


            myVarStatic = 10;
            Console.WriteLine(myVarStatic);


            #endregion

            #region PrivateConstructors

            //object of a class having private constructor cannot be instantiated from outside of the class. 
            //However, we can create object of the class inside class methods itself.
            //If we want to stop object creation of a class, then we can make the class constructor private.

            // PrivateConst objPrivateConst = new PrivateConst(); //Error cannot access private constructor

            #endregion

            #region Destructors

            //Destructor is used to clean up the memory and free the resources.
            //In C# this is done by the garbage collector on its own.
            //System.GC.Collect() is called internally for cleaning up. But sometimes it may be necessary to implement destructors manually.

            #endregion

            #region TryCatchFinally

            //The finally statement lets you execute code, after try...catch, regardless of the result:

            try
            {
                Employee objTryCatch = new Employee();
                if (objTryCatch.AgeTryCatch < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong.");
                throw ex;
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            #endregion

            #region ArrayList

            //add an item to a C# ArrayList
            ArrayList resultList = new ArrayList();
            resultList.Add(90);
            resultList.Add(95);
            Console.Read();

            //read elements from an ArrayList

            string arrayItem = string.Empty;
            ArrayList personList = new ArrayList();
            personList.Add("Sandeep");
            personList.Add("Raviendra");
            foreach (var item in personList)
            {
                arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(arrayItem);
            }
            Console.Read();

            Console.WriteLine("=====Original List======");
            for (int i1 = 0; i1 < personList.Count; i1++)
            {
                Console.WriteLine(arrayItem);
            }

            personList.Insert(1, "Shaijal");
            Console.WriteLine("=====Modify List======");
            for (int i2 = 0; i2 < personList.Count; i2++)
            {
                Console.WriteLine(arrayItem);
            }
            Console.Read();

            personList.Remove("Sandeep");
            Console.WriteLine("=====Modified List======");
            for (int i3 = 0; i3 < personList.Count; i3++)
            {
                arrayItem = string.Format($"Name  is {personList[i3]}");
                Console.WriteLine(arrayItem);
            }
            Console.Read();

            //remove first item from person list using index  
            personList.RemoveAt(0);
            Console.WriteLine("=====Modified List======");
            for (int i4 = 0; i4 < personList.Count; i4++)
            {
                arrayItem = string.Format($"Name  is {personList[i4]}");
                Console.WriteLine(arrayItem);
            }
            Console.Read();

            //remove first two item from person list using index  
            personList.RemoveRange(0, 2);
            Console.WriteLine("=====Modified List======");
            for (int i5 = 0; i5 < personList.Count; i5++)
            {
                arrayItem = string.Format($"Name  is {personList[i5]}");
                Console.WriteLine(arrayItem);
            }
            Console.Read();

            int totalItems = personList.Count;
            personList.Clear();

            totalItems = personList.Count;
            Console.WriteLine(string.Format($"Total Number Of Items in ArrayList: {totalItems}"));
            Console.Read();

            #endregion

            #region WhatistheOutput
            baseclass bOP = new derivedclass();
            bOP.func1();
            bOP.func2();
            bOP.func3();


            sample sOP = new sample(4);
            sample tOP = new sample();
            Console.ReadLine();

            derived kOP = new derived(12);
            Console.ReadLine();

            sample2 t2OP = new sample2(10);
            Console.ReadLine();

            sampleQ4 s2OP = new sampleQ4(100);
            Console.ReadLine();

            #endregion

            #region Linkedlist Impl
            //https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

            SLLCaller();
            Console.ReadLine();
            Console.ReadLine();

            #endregion

            #region .tostring and Convert.tostring

            //Both the methods are used to convert the string but the basic difference between them is:
            //"Convert" function handles NULLS, 
            //while "i.ToString()" does not it will throw a NULL reference exception error.

            string xyz;
            object abc = null;
            xyz = abc.ToString();
            //returns a null reference exception for s.

            string efg;
            object hij = null;
            efg = Convert.ToString(hij);
            //returns an empty string for s and does not throw an exception

            #endregion

            #region Static and Dynamic

            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Address);
            Console.Read();

            //access static members  
            Employee.DisplayCollegeDetails();

            //acess non-static members  
            Console.WriteLine();
            Employee s1 = new Employee();
            Employee s2 = new Employee();
            s1.SetStudentDetails("Sarath", "MCA");
            s1.SetStudentDetails("Syam", "MBA");
            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            Console.Read();

            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Address);
            Console.Read();

            #endregion

            #region Void and No Params

            // Function with void and no parameter -- here void means no return type
            void veranda()
            {
                int Noofchair = 0;
                Console.WriteLine("Welcome to veranda void");
                Noofchair = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("I have total " + Noofchair + " Chairs in my Veranda");
            }

            void checkAge(int age)
            {
                if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                }
            }


            checkAge(15); //System.ArithmeticException: 'Access denied - You must be at least 18 years old.'
            checkAge(20); //Access granted - You are old enough!

            #endregion

            #region PolyMorphism

            TestData dataClass = new TestData();
            int add2 = dataClass.Add(45, 34, 67);
            int add1 = dataClass.Add(23, 34);


            Drawing circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());

            #endregion

            #region ValTypeRefType

            //Stack uses LIFO


            int valueTypeX = 10; //value type ; value 10 is stored in an area of memory called the stack.
            int[] iArray = new int[20]; // Reference Type ; Space Reqd for the 20 integers is allocated on the heap.

            Console.WriteLine(valueTypeX);

            #endregion

            #region Indexer 

            IndexedNames namesIndexer = new IndexedNames();
            namesIndexer[0] = "Zara";
            namesIndexer[1] = "Riz";
            namesIndexer[2] = "Nuha";
            namesIndexer[3] = "Asif";
            namesIndexer[4] = "Davinder";
            namesIndexer[5] = "Sunil";
            namesIndexer[6] = "Rubic";

            for (int iIndexer = 0; iIndexer < IndexedNames.size; iIndexer++)
            {
                Console.WriteLine(namesIndexer[iIndexer]);
            }
            Console.ReadKey();

            #endregion

            #region Dynamic Example

            //Dynamic data types are dynamic in nature and don’t require initialization at the time of declaration. 
            //It also means that a dynamic type does not have a predefined type and can be used to store any type of data.

            DemoDynamic objDynamicDemo = new DemoDynamic();
            dynamic value1 = 10;
            dynamic value2 = 11;
            dynamic Str = "Your Result Is: ";
            Console.WriteLine(Str + objDynamicDemo.Method(value1, value2));
            Console.ReadLine();


            //We can change the types for a dynamic data type.
            //In the above example we assign the int, float, string, object and types for dynamic data type(obj).
            //Size of dynamic data type is calculated the values that is assigned for dynamic data type.

            dynamic obj;

            obj = "Pankaj Kumar Choudhary";
            Console.WriteLine(obj);

            obj = 12345;
            Console.WriteLine(obj);

            obj = 123.45;
            Console.WriteLine(obj);

            obj = false;
            Console.WriteLine(obj);

            obj = new Dictionary<int, String>();
            obj[0] = "Haryana";
            obj[1] = "Rajasthan";
            obj[2] = "Punjab";
            obj[3] = "Goa";
            foreach (var index in obj.Keys)
            {
                Console.WriteLine(obj[index]);
            }
            Console.ReadLine();

            #endregion

            #region OptionalParams

            OPtionalParams objOptionalParms = new OPtionalParams();

            objOptionalParms.AddNumbers(38, 4);
            objOptionalParms.AddNumbers(36, 4, 2);

            #endregion

            #region OperationswithConstants
            ConsOperations objConsOperations = new ConsOperations();
            int addedValue, subtractedValue;
            objConsOperations.DoMath(10, 5, out addedValue, out subtractedValue);
            Console.WriteLine(addedValue);
            Console.WriteLine(subtractedValue);

            #endregion

            #region PartialClass

            //partial class instance    
            partialclassDemo objPartialClass = new partialclassDemo();
            objPartialClass.method1();
            objPartialClass.method2();

            #endregion

            #region PolymorphismExample

            hrDepart obj1 = new hrDepart();
            itDepart obj2 = new itDepart();
            financeDepart obj3 = new financeDepart();

            obj1.LeaderName();
            obj2.LeaderName();
            obj3.LeaderName();

            Console.ReadKey();

            #endregion

            #region AbstarctClassExample

            // class instance    
            new test().displayData();

            #endregion

            #region Operators

            int OperX = 2, OperY = 4;

            OperX = OperX + 5;
            OperX += 5;

            OperX = OperX - 5;
            OperX -= 5;

            OperY = OperY * 5;
            OperX *= 5;

            #endregion

            #region TryCatch & Execeptions

            int xMultiCatch = 0;
            int div = 0;
            try
            {
                div = 100 / xMultiCatch;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException de)
            {
                throw de;

            }
            catch (Exception ee)
            {
                throw ee;

            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Result is {0}", div);

            Employee pExeception = new Employee();

            try
            {
                pExeception.ExceptionMethod();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            #endregion

            #region  Equality Operator (==) and Equals() Method
            string nameEql = "sandeep";
            string myName = nameEql;
            Console.WriteLine("== operator result is {0}", nameEql == myName);
            Console.WriteLine("Equals method result is {0}", nameEql.Equals(myName));
            Console.ReadKey();

            #endregion

            #region Refelections
            //Reflection is a process by which a computer program can monitor and modify its own structure and behavior.
            //It is a way to explore the structure of classes, resources, methods at run time.
            //Reflection is the capability to find out the information about objects, metadata, and application details at run-time.

            Console.WriteLine("*********Methods*********");
            MethodInfo[] mth = t.GetMethods();
            foreach (MethodInfo mRef in mth)
            {
                Console.WriteLine("-->{0}", mRef.Name);
            }

            Employee oMyClass = new Employee();
            //Type information.
            Type oMyType = oMyClass.GetType();
            //Method information.
            MethodInfo oMyMethodInfo = oMyType.GetMethod("Add");

            Console.WriteLine("nType information:" + oMyType.FullName);
            Console.WriteLine("nMethod info:" + oMyMethodInfo.Name);
            Console.Read();

            #endregion

            #region ListandDictionaryEg


            //C# Dictionary class is a generic collection of keys and values pair of data.
            //The Dictionary class defined in the System.Collections.Generic namespace is a generic class 
            //it can store any data types in a form of keys and values. Each key must be unique in the collection.

            //The Dictionary maps a key to a value and cannot have duplicate keys, 
            //A list just contains a collection of values.Also Lists allow duplicate items and support linear traversal.

            List<int> listValues = new List<int>();
            listValues.Add(2);
            listValues.Add(3);
            listValues.Add(5);

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("cat", 2);
            d.Add("dog", 1);

            //The following code snippet creates a dictionary where the key type is string and value type is also string.
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
            EmployeeList.Add("Mahesh Chand", "Programmer");
            EmployeeList.Add("Praveen Kumar", "Project Manager");
            EmployeeList.Add("Raj Kumar", "Architect");
            EmployeeList.Add("Nipun Tomar", "Asst. Project Manager");

            //The following code snippet creates a dictionary where the key type is string and value type is short integer.
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);

            //read a value from a dictionary
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }

            #endregion

            #region ForLoop with Brk statements

            for (int iContinue = 0; iContinue <= 5; iContinue++)
            {
                if (iContinue == 4)
                {
                    break;
                }
                Console.WriteLine("The number is " + iContinue);
                Console.ReadLine();
            }


            //output is
            //The number is 0;
            //The number is 1;
            //The number is 2;
            //The number is 3;

            for (int ibrk = 0; ibrk <= 5; ibrk++)
            {
                if (ibrk == 4)
                {
                    continue;
                }
                Console.WriteLine("The number is " + ibrk);

                Console.ReadLine();
            }

            //output is
            //The number is 0;
            //The number is 1;
            //The number is 2;
            //The number is 3;
            //The number is 5;



            //The throw statement allows you to create a custom error.
            //The throw statement is used together with an exception class. 
            //There are many exception classes available in C#: ArithmeticException,FileNotFoundException,IndexOutOfRangeException,
            //TimeOutException, etc:

            #endregion

            #region Queue

            //A Queue represents a first -in, first -out (FIFO)collection of objects. 
            //An example of a queue is a line of people waiting.
            //The Queue<T> class in the System.Collection.Generic namespace represents a queue in C#, 
            //where T specifies the type of elements in the queue. 

            string[] courses = {
                "MCA",
                "MBA",
                "BCA",
                "BBA",
                "BTech",
                "MTech"
            };
            Queue<string> queue1 = new Queue<string>();
            Queue<string> queue2 = new Queue<string>(courses);
            Queue<string> queue3 = new Queue<string>(4);
            Console.WriteLine("Number of elements in queue1:" + queue1.Count());
            Console.WriteLine("Number of elements in queue2:" + queue2.Count());
            Console.WriteLine("Number of elements in queue3:" + queue3.Count());

            #endregion

            #region Stack
            Stack<string> stack1 = new Stack<string>();
            string[] strStack = {
                "MCA",
                "BCA",
                "BBA",
                "MBA",
                "MTech"
            };
            Stack<string> stack2 = new Stack<string>(strStack);
            Stack<string> stack3 = new Stack<string>(10);
            Console.WriteLine("The elements in the stack1 are:" + stack1.Count());
            Console.WriteLine("The elements in the stack2 are:" + stack2.Count());
            Console.WriteLine("The elements in the stack3 are:" + stack3.Count());

            Stack<string> stack21 = new Stack<string>(strStack);
            Stack<string> stack31 = new Stack<string>(10);
            stack1.Push("************");
            stack1.Push("MCA");
            stack1.Push("MBA");
            stack1.Push("BCA");
            stack1.Push("BBA");
            stack1.Push("***********");
            stack1.Push("**Courses**");
            stack1.Push("***********");
            Console.WriteLine("The elements in the stack1 are as:");
            foreach (string stck in stack1)
            {
                Console.WriteLine(stck);
            }
            Console.WriteLine("The elements in the stack2 are as:");
            foreach (string stck in stack21)
            {
                Console.WriteLine(stck);
            }
            stack3.Push("one");
            stack3.Push("Two");
            Console.WriteLine("The elements in the stack3 are as:");
            foreach (string s in stack3)
            {
                Console.WriteLine(s);
            }

            //For remove/or pop the element pop() method is used  
            stack1.Pop();
            stack1.Pop();
            stack1.Pop();
            Console.WriteLine("After removal/or pop the element the stack is as:");
            //the element that inserted in last is remove firstly.  
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }

            #endregion

            #region StringCollection

            // Create a StringCollection object
            StringCollection authorNames = new StringCollection();

            // Add string using Add method
            authorNames.Add("Mahesh Chand");
            authorNames.Add("Mike Gold");
            authorNames.Add("Praveen Kumar");
            authorNames.Add("Raj Beniwal");

            // Add an array of string using AddRange            
            string[] names = new string[] { "Mahesh Chand", "Mike Gold", "Praveen Kumar", "Raj Beniwal" };
            authorNames.AddRange(names);

            // Insert an string at a specified index
            authorNames.Insert(5, "New Author");

            // authorNames.Clear();
            // authorNames.Remove("Mike Gold");
            // authorNames.RemoveAt(5);

            if (authorNames.Contains("Mike Gold"))
            {
                Console.WriteLine("Mike Gold is at position: " + authorNames.IndexOf("Mike Gold"));
            }

            int authorLocation = authorNames.IndexOf("Mike Gold");
            string authorName = authorNames[authorLocation];

            Console.WriteLine("Position of Mike Gold is " + authorLocation.ToString());

            Console.WriteLine("Total items in string collection: " + authorNames.Count.ToString());

            foreach (string name in authorNames)
            {
                Console.WriteLine(name);
            }

            // Copy Collection to new Array
            string[] newAuthorList = new string[authorNames.Count];
            authorNames.CopyTo(newAuthorList, 0);

            foreach (string name in newAuthorList)
            {
                Console.WriteLine(name);
            }
            //int[] intArray = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            //foreach (int i in intArray)
            //{
            //    System.Console.WriteLine(i);
            //}

            Console.ReadLine();

            #endregion

            #region Regex in C#

            string strRegx = "A Thousand Splendid Suns";
            Console.WriteLine("Matching words that start with 'S': ");
            showMatch(strRegx, @"\bS\S*");



            string strRegex1 = "make maze and manage to measure it";
            Console.WriteLine("Matching words start with 'm' and ends with 'e':");
            showMatchPattern(strRegex1, @"\bm\S*e\b");


            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);


            #endregion

            #region Create multiple objects For one class

            Employee EMP = new Employee();

            EMP.color = "RED";
            EMP.model = "HATCHBACK";
            EMP.year = 2020;

            Employee Newemp = new Employee();

            Newemp.color = "Green";
            Newemp.model = "SEDAN";

            #endregion

            #region ConsturctorExample

            Employee Ford = new Employee();  // Create obj of the Employee Class(this will call the constructor)
            Console.WriteLine(Ford.Carmodel);

            Employee FordNew = new Employee("MACH E");  // Create obj of the Employee Class(this will call the constructor)
            Console.WriteLine(FordNew.Carmodel);

            Employee emp1Constructor = new Employee("Vithal", 23);  // Create a new employee object.  
            Employee emp2Constructor = new Employee(emp1Constructor);// here is emp1 details is copied to emp2.  
            Console.WriteLine(emp2Constructor.Details);
            Console.ReadLine();

            #endregion

            #region Anonmyous Function
            func f1 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(f1(1, 2));

            #endregion

            #region LetClauseLinq
            var namesLetClause = new string[] { "Dog", "Cat", "Giraffe", "Monkey", "Tortoise" };
            var resultLetClause =
                from animalName in names
                let nameLength = animalName.Length
                where nameLength > 3
                orderby nameLength
                select animalName;

            #endregion

            #region TypeCasting

            //implicit type casting
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);

            //explicit type casting
            myDouble = 9.78;
            myInt = (int)myDouble;    // Manual casting: double to int
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);

            //Type conversion
            myInt = 10;
            myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            #endregion

            #region String Operations

            StringBuilder sb = new StringBuilder("Hello ", 50);
            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);

            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:C} ", 25);
            Console.WriteLine(amountMsg);

            #endregion

            #region SwitchCase
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            #endregion

            #region Tuple

            //Tuple < T > A tuple is a data structure that contains a sequence of elements of different data types.
            //It can be used where you want to have a data structure to hold an object with properties of differnt datatype

            var person = Tuple.Create(1, "Steve", "Jobs");
            var Tup1 = person.Item1; // returns 1
            var Tup2 = person.Item2; // returns "Steve"
            var Tup3 = person.Item3; // returns "Jobs"

            //Tuple inside Tuple

            var numbersT2 = Tuple.Create(1, 2, 3.5, 4, 5.5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            var TupI1 = numbersT2.Item1; // returns 1
            var TupI2 = numbersT2.Item7; // returns 7
            var TupI3 = numbersT2.Rest.Item1; //returns (8, 9, 10, 11, 12, 13)
            var TupI4 = numbersT2.Rest.Item1.Item1; //returns 8
            var TupI5 = numbersT2.Rest.Item1.Item2; //returns 9


            #endregion

            #region Loops
            //while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //for each loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string j in cars)
            {
                Console.WriteLine(j);
            }

            for (int q = 0; q < 10; q++)
            {
                if (q == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int s = 0; s < 10; s++)
            {
                if (s == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            #endregion

            #region Nullable int & coalescing 

            int? x = 3;
            int y = 3;
            bool check = false;

            if (x == y)
            {
                check = true;
                Console.WriteLine(check.ToString());
                Console.ReadLine();
            }

            int? xNull = null;
            int yNull = 4;
            int? resultNotNull;

            resultNotNull = xNull ?? yNull;
            Console.WriteLine(result.ToString());
            Console.ReadLine();

            int? xNullCoalesc = null;
            int yNullCoalesc = -1;

            // when x is null, z = y
            // when x is not null, z = x
            int zNullCoalesc = xNullCoalesc ?? yNullCoalesc; // where x and y are left and right operand

            #endregion

            #region Arrays

            //Declaring and initializing a jagged array.
            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[10];
            jaggedArray[0] = new int[] { 3, 5, 7, };
            jaggedArray[1] = new int[] { 1, 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 1, 6 };
            jaggedArray[3] = new int[] { 1, 0, 2, 4, 6, 45, 67, 78 };
            jaggedArray[4] = new int[] { 1, 0, 2, 4, 6, 34, 54, 67, 87, 78 };

            string[] NewCars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string f in NewCars)
            {
                Console.WriteLine(f);
            }

            //Array Operation using Linq
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());

            //A jagged array is an array of array. Jagged arrays store arrays instead of literal values.
            //A jagged array is initialized with two square brackets[][].The first bracket specifies the size of an array 
            //second bracket specifies the dimensions of the array which is going to be stored.

            int[][] jArray1 = new int[2][]; // can include two single-dimensional arrays 
            int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays 

            // Multi Dimensional array
            int[,] arr2d = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //arr2d[0, 0]; //returns 1
            //arr2d[0, 1]; //returns 2
            //arr2d[1, 0]; //returns 3
            //arr2d[1, 1]; //returns 4
            //arr2d[2, 0]; //returns 5
            //arr2d[2, 1]; //returns 6

            #endregion

            #region Method Overloading

            // Multiple methods can have the same name as long as the number and/or type of parameters are different.

            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);

            int myNumIntOvld = PlusMethod(8, 5);
            double myNumDblOvld = PlusMethod(4.3, 6.26);

            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            Console.WriteLine("Int: " + myNumIntOvld);
            Console.WriteLine("Double: " + myNumDblOvld);

            Shape ob = new Shape();
            ob.Area(2.0f);
            ob.Area(20.0f, 30.0f);
            ob.Area(2.0f, 3.0f, 4.0f);
            Console.ReadLine();

            #endregion

            #region OperatorOverload

            Complex c1 = new Complex(10, 20);
            c1.ShowXY(); // displays 10 & 20  
            Complex c2 = new Complex();
            c2.ShowXY(); // displays 0 & 0  
            c2 = -c1;
            c2.ShowXY(); // diapls -10 & -20 

            #endregion

            #region InheritanceEg

            //we can use and access all  the methods and values of the Base class in Dervied class using inheritance
            PassVehicle myPassVechileObj = new PassVehicle();
            MyCar myCarobj = new MyCar();
            myPassVechileObj.honk();
            myCarobj.honk();
            var ModelName = myCarobj.modelName;
            var bradName = myPassVechileObj.brand;

            // Display the value of the brand field (from the PassVehicle class) and the value of the modelName from the MyCar class
            Console.WriteLine(myPassVechileObj.brand + " ");

            C C1 = new C();
            C1.A_Method();
            C1.B_Method();
            C1.C_Method();

            #endregion

            #region MethodOverridingEg

            //1. Base class method overrides the derived class method, when they share the same name.
            //2. override the base class method by adding the virtual keyword to the method inside the base class and 
            // using the override keyword for each derived class methods

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();





            #endregion

            #region MethodOverriding With New

            SampleA aSample = new SampleA();
            SampleB bSample = new SampleB();
            aSample.Show();
            bSample.Show();
            aSample = new SampleB();
            aSample.Show();
            Console.ReadLine();

            #endregion

            #region AbstractClass

            //Abstract class is a restricted class that cannot be used to create objects.
            // To access it, it must be inherited from another class
            //Use Abstract Classes and Methods to achieve security -- hide certain details and show important details of an object.

            //WildAnimal myObjWildAnimal = new WildAnimal(); //Cannot create an instance of the abstract class or interface WildAnimal
            WildPigAbstract myobjWildPigAbstract = new WildPigAbstract();//This class inherits base class which is a Abstract class

            myobjWildPigAbstract.WildanimalSoundAbs(); //From Base class
            myobjWildPigAbstract.SpaceRocket();
            myobjWildPigAbstract.Spacesleep();
            myobjWildPigAbstract.AddAnimal(); // From Derived class

            #endregion

            #region Queue

            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            foreach (Object objQueue in qt)
            {
                Console.WriteLine(objQueue);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the Queue " + qt.Count);
            Console.WriteLine("Does the Queue contain " + qt.Contains(3));


            #endregion

            #region Struct Sample
            Console.WriteLine("Struct Sample!");

            // Create a Book object  
            Book myBook = new Book();
            myBook.Title = "Simplified C#";
            myBook.Author = "Mahesh Chand";
            myBook.Price = 45.95M;
            myBook.Year = 2017;

            Console.WriteLine($"Book {myBook.Title} was written by {myBook.Author}" + $" in {myBook.Year}. Price is {myBook.Price}");

            Console.ReadKey();

            #endregion

            #region Copy and Clone
            //Clone will copy the structure of a data  
            //Copy will copy the complete structure as well as data

            int[] arrSource = new int[2];
            arrSource[0] = 5;
            arrSource[1] = 9;

            int[] arrTarget = new int[2];
            int[] arrTargetClone = new int[2];

            arrSource.CopyTo(arrTarget, 0);
            arrTargetClone = (int[])arrSource.Clone();
            Console.WriteLine(arrTarget);

            #endregion

            #region SortedLists

            SortedList sl = new SortedList();

            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");

            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Nuha Ali");
            }
            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }

            #endregion

            #region SealedClass

            //Sealed classes are used to restrict the inheritance feature 
            //Once a class is defined as a sealed class, this class cannot be inherited.
            //sealed modifier is used to declare a class as sealed. ... If a class is derived from a sealed class, compiler throws an error.

            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());

            #endregion

            #region LinqExamples

            #region ImplicitExplicit

            var implict = 20;
            int Explicit = 30;
            Console.WriteLine(Explicit + implict);

            var strImpl = implict;
            var Name = "bharaath";
            Console.WriteLine(Name + strImpl);

            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student.Id); //output: 1
            Console.WriteLine(student.FirstName); //output: James
            Console.WriteLine(student.LastName); //output: Bond

            #endregion

            #region Anonymous

            //Anonymous types are immutable.
            // Datatypes need not be specified during Decalre or intitalize

            var myArrayWithAntype = new int[] { 1, 2, 12, 53, 58, 8, 2113, 2221 };
            var fullname = new { FirstName = "Gaurav", LastName = "Arora" };

            Console.WriteLine(fullname.FirstName);
            Console.WriteLine(fullname);


            var anonymousData = new
            {
                ForeName = "Jignesh",
                SurName = "Trivedi"
            };

            Console.WriteLine("First Name : " + anonymousData.ForeName);


            #endregion

            #region LambdaExperssion

            //Lambda expressions are anonymous functions that contain expressions or sequence of operators. 
            // All lambda expressions use the lambda operator =>, that can be read as "goes to" or "becomes".
            //left side of the lambda operator specifies the i/p param and the right side holds an exprression or a code block that works with
            //the entry parameters.

            List<int> Lambdalist = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = Lambdalist.FindAll(lamdax => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();


            var dogsEmpty = new List<LinqDog>();

            List<LinqDog> dogs = new List<LinqDog>()
            {
            new LinqDog { LinqName = "Rex", LinqAge = 4 },
            new LinqDog { LinqName = "Sean", LinqAge = 0 },
            new LinqDog { LinqName = "Stacy", LinqAge = 3 }
            };

            var namesList = dogs.Select(Linqx => Linqx.LinqName);
            foreach (var name in namesList)
            {
                Console.WriteLine(namesList);
            }
            Console.Read();

            #endregion

            #region SingleorDefault

            List<LinqclsTest> lstTest = new List<LinqclsTest>();
            LinqclsTest Row1 = new LinqclsTest { Id = "1", Name = "AA" };
            LinqclsTest Row2 = new LinqclsTest { Id = "2", Name = "BB" };
            LinqclsTest Row3 = new LinqclsTest { Id = "3", Name = "CC" };
            LinqclsTest Row4 = new LinqclsTest { Id = "4", Name = "AA" };
            LinqclsTest Row5 = new LinqclsTest { Id = "5", Name = "AA" };

            lstTest.Add(Row1);
            lstTest.Add(Row2);
            lstTest.Add(Row3);
            lstTest.Add(Row4);
            lstTest.Add(Row5);

            var Fod = lstTest.Where(l => l.Name == "AA").FirstOrDefault(); // Works
            var Sod = lstTest.Where(l => l.Name == "AA").SingleOrDefault(); // error as Sequence which contains more than one element

            #endregion

            #region MinMax & Nth

            var val = new int[] { 99, 35, 26, 87 };

            var maxNum = val.Max(z => z);
            Console.WriteLine("Maximum Number: " + maxNum);

            var minNum = val.Min(z => z);
            Console.WriteLine("Minimum Number: " + minNum);

            var secondMax = val.OrderByDescending(z => z).Skip(1).First();
            Console.WriteLine("Second Largest Number: " + secondMax);

            var secondMin = val.OrderBy(z => z).Skip(1).First();
            Console.WriteLine("Second Smallest Number: " + secondMin);

            #endregion

            #region Any All Contains

            var sortedDogs = dogs.OrderByDescending(linqx => linqx.LinqName);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.LinqName, dog.LinqAge));
            }

            // false because dogsEmpty is empty
            var hasAtLeastOne = dogsEmpty.Any();

            // true because dogs has at least one item (not empty)
            hasAtLeastOne = dogs.Any();
            hasAtLeastOne = dogs.All(LinqDog => LinqDog.LinqAge > 10);

            List<LinqStudentList> students = new List<LinqStudentList>();
            var student1 = new LinqStudentList() { ID = 101, Name = "Priyanka", TotalMarks = 275 };
            var student2 = new LinqStudentList() { ID = 102, Name = "Preety", TotalMarks = 375 };

            students.Add(student1);
            students.Add(student2);

            //Using Method Syntax
            var IsExistsMS = students.Contains(student2);

            //Using Query Syntax
            var IsExistsQS = (from num in students select num).Contains(student1);

            Console.WriteLine(IsExistsMS);


            #endregion

            #region Eager Lazy Explicit Loading

            //Eager Loading helps you to load all your needed entities at once; All your child entities will be loaded at single database call.
            //This can be achieved, using the Include method, which returns the related entities as a part of the query 
            //large amount of data is loaded at once.

            //User usr = dbContext.Users.Include(a => a.UserDetails).FirstOrDefault(a => a.UserId == userId);


            //Lazy Loading default behavior of an EF where a child entity is loaded only when it is accessed for the first time.
            //It simply delays the loading of the related data, until you ask for it.

            // User usr = dbContext.Users.FirstOrDefault(a => a.UserId == userId);

            //EXPLICIT lOADING
            //After turning Lazy Loading off, you can still load the entities by explicitly calling the Load method for the related entities.
            //There are two ways to use Load method Reference(to load single navigation property) and Collection(to load collections)

            //User usr = dbContext.Users.FirstOrDefault(a => a.UserId == userId);
            //dbContext.Entry(usr).Reference(usr => usr.UserDetails).Load();

            #endregion

            #region Union & Intersect

            List<int> collectionOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> collectionTwo = new List<int>() { 1, 2, 3, 11, 12, 13, 14, 15 };

            var unionResult = collectionOne.Union(collectionTwo);
            var IntersectResult = collectionOne.Intersect(collectionTwo);
            var exceptResult = collectionOne.Except(collectionTwo);

            foreach (var item in unionResult)
            {
                Console.Write(item + " ");
            }

            #endregion

            #region DeferedExecution & ImmediateExecution

            var Emp_List = new List<LinqEmployeeIExec>(
                new LinqEmployeeIExec[]
                {
                    new LinqEmployeeIExec{Emp_ID=1, Name="Shambhu Sharma", Email="shambhu@shambhu.com", Country="India"},
                    new LinqEmployeeIExec{Emp_ID=2, Name="Manu Khanna", Email="manu@manu.com", Country="India"},
                    new LinqEmployeeIExec{Emp_ID=3, Name="Abhishek Nigam", Email="abhishek@abhishek.com", Country="USA"},
                    new LinqEmployeeIExec{Emp_ID=4, Name="Yogesh Gupta", Email="yogesh@yogesh.com", Country="USA"},
                    new LinqEmployeeIExec{Emp_ID=5, Name="Shweta Kashyap", Email="Shweta@Shweta.com", Country="India"},
                    new LinqEmployeeIExec{Emp_ID=6, Name="Shraddha Gaur", Email="Shraddha@Shraddha.com", Country="India"},
                    new LinqEmployeeIExec{Emp_ID=7, Name="Akhilesh Atwal", Email="Akhilesh@Akhilesh.com", Country="India"},
                    new LinqEmployeeIExec{Emp_ID=6, Name="Mayank Dhulekar", Email="Mayank@Mayank.com", Country="USA"},
                    new LinqEmployeeIExec{Emp_ID=7, Name="Saurabh Mehrotra", Email="Saurabh@Saurabh.com", Country="USA"},
                    new LinqEmployeeIExec{Emp_ID=7, Name="Mehak Jain", Email="Mehak@Mehak.com", Country="India"},
                });

            //Deferred Execution Example

            var Result = (from SelectedVal in Emp_List                     // Query does Not Execute Here
                          where SelectedVal.Country.Equals("India")
                          select new { SelectedVal.Name });

            //To See Deferred Execution I am going to add a new Record with Country India
            // Emp_List.Add(new Employee { Emp_ID = 8, Name = "Rahul Saxena", Email = "rahulsaxena@live.com", Country = "India" });

            foreach (var Employee in Result)                         // Query Execute here
            {
                Console.WriteLine(Employee.Name);
            }


            //========================================================================================================================
            //Immediate Execution Example
            var Result2 = (from a in Emp_List                     // Query Execute Here
                           where a.Country.Equals("India")
                           select new { a.Name }).ToList();

            //To See Deferred Execution I am going to add a new Record with Country India
            Emp_List.Add(new LinqEmployeeIExec { Emp_ID = 8, Name = "Rahul Saxena", Email = "rahulsaxena@live.com", Country = "India" });

            foreach (var Employee in Result)                         // Query Execute here
            {
                Console.WriteLine(Employee.Name);
            }

            #endregion

            #region LinqJoins 
            List<LinqEmployeeJoin> li = new List<LinqEmployeeJoin>();
            li.Add(new LinqEmployeeJoin { Id = 1, age = 19, name = "Ritesh", gender = "M" });
            li.Add(new LinqEmployeeJoin { Id = 2, age = 20, name = "sujit", gender = "M" });
            li.Add(new LinqEmployeeJoin { Id = 3, age = 23, name = "Kabir", gender = "F" });
            li.Add(new LinqEmployeeJoin { Id = 4, age = 3, name = "mantu", gender = "F" });
            li.Add(new LinqEmployeeJoin { Id = 5, age = 24, name = "Kamlesh", gender = "M" });
            li.Add(new LinqEmployeeJoin { Id = 6, age = 28, name = "Manoj", gender = "M" });


            List<LInqDepartmentJoin> Deli = new List<LInqDepartmentJoin>();
            Deli.Add(new LInqDepartmentJoin { id = 2, Departments = "IT", Location = "Bangalore" });
            Deli.Add(new LInqDepartmentJoin { id = 8, Departments = "IT", Location = "Bangalore" });
            Deli.Add(new LInqDepartmentJoin { id = 3, Departments = "HR", Location = "Bangalore" });
            Deli.Add(new LInqDepartmentJoin { id = 7, Departments = "HR", Location = "Bangalore" });
            Deli.Add(new LInqDepartmentJoin { id = 6, Departments = "Account", Location = "Bangalore" });

            var Joinresult = from emp in li
                             join
                              de in Deli
                             on emp.Id equals de.id
                             select new
                             {
                                 EmployeeId = emp.Id,
                                 EmployeeName = emp.name,
                                 Department = de.Departments,
                                 Location = de.Location
                             };

            Console.WriteLine(" ID\t\tName\t\t DepartmentName \t\tLocation");

            foreach (var objJoin in Joinresult)
            {
                Console.WriteLine(objJoin.EmployeeId + "\t\t" + objJoin.EmployeeName +
                "\t\t" + objJoin.Department + "\t\t\t\t" + objJoin.Location);
            }

            Console.ReadLine();

            List<LinqEmployee> employees = new List<LinqEmployee>();
            LinqEmployee emp1 = new LinqEmployee { Name = "Deepak", Skills = new List<string> { "C", "C++", "Java" } };
            LinqEmployee emp2 = new LinqEmployee { Name = "Karan", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };
            LinqEmployee emp3 = new LinqEmployee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            IEnumerable<List<String>> resultSelect = employees.Select(e => e.Skills);

            Console.WriteLine("**************** Select ******************");

            // Two foreach loops are required to iterate through the results
            // because the query returns a collection of arrays.

            foreach (List<String> skillList in resultSelect)
            {
                foreach (string skill in skillList)
                {
                    Console.WriteLine(skill);
                }
                Console.WriteLine();
            }

            // Query using SelectMany()
            IEnumerable<string> resultSelectMany = employees.SelectMany(emp => emp.Skills);

            Console.WriteLine("**************** SelectMany ******************");

            // Only one foreach loop is required to iterate through the results 
            // since query returns a one-dimensional collection.
            foreach (string skill in resultSelectMany)
            {
                Console.WriteLine(skill);
            }

            #endregion

            #endregion

            #region Ternary Operators

            //Boolean Expression ? First Statement : Second Statement

            int ValueA = 20, ValueB = 10;
            var resultTerinary = ValueA > ValueB ? ValueA : ValueB;
            Console.WriteLine(resultTerinary);

            #endregion

            #region Extension Mtd

            //Extension methods, as the name suggests, are additional methods.
            //Extension methods allow you to inject additional methods without modifying,deriving the original class struct or Interface 
            //Extension methods can be added to your own custom class, .NET framework classes, or third party classes or interfaces.

            int iExtensionMtd = 10;
            bool resultExtensionMethod = iExtensionMtd.IsGreaterThan(100);
            Console.WriteLine(result);

            #endregion

            #region Threading
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            Console.WriteLine("This is {0}", th.Name);


            ThreadStart childref = new ThreadStart(CallToChildThreadDestroy);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(childref);
            childThread.Start();


            ThreadStart childrefDestroy = new ThreadStart(CallToChildThreadDestroy);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThreadDestory = new Thread(childref);
            childThread.Start();

            //stop the main thread for some time
            Thread.Sleep(2000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");

            childThread.Abort();


            #endregion

            #region Delegate

            //A delegate is an object which refers to a method 
            //it is a reference type variable that can hold a reference to the methods.
            //Delegates in C# = to function pointer in C/C++. It tells which method is to be called when an event is triggered.

            double totalInterest;
            //Method I : Invocation of simple delegate by using Invoke keyword
            totalInterest = SI.Invoke(120, 1, 3.25);
            Console.WriteLine("Total Interest of $120 in a year at rate of 3.25 % APR is { 0 }", totalInterest);

            //Method II : Invocation of simple delegate by passing method name
            CalculateSimpleInterest D = new CalculateSimpleInterest(getTotalInterest);
            totalInterest = D(120, 1, 3.25);
            Console.WriteLine("Total Interest of $120 in a year at rate of 3.25 % APR is { 0 }", totalInterest);
            Console.ReadKey();



            MyDelegate objMyDelegare = new MyDelegate(GetData);
            objMyDelegare += new MyDelegate(GetDat_one);

            //GetData and GetDat_one is called  
            objMyDelegare("Mahesh");
            objMyDelegare -= new MyDelegate(GetDat_one);

            List<Printer> printers = new List<Printer>();
            int iDel = 0;
            for (; iDel < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }

            #endregion

            #region AsyncAwait

            //we are calling a ReadFile method to read the contents of a text file and get the length of the characters present in the text file.
            //In our sampleText.txt, file contains too many characters, so It will take a long time to read all the characters.
            //So we are using async programming to read all the contents from the file,
            //So it will not wait to get a return value from this method and execute the other lines of code 

            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();


            #endregion

            #region DesignPatterns Example

            #region Factory Pattern

            //The factory pattern is the process of object creation and allows the object to be created at run-time when it is required.
            //In Factory pattern, we create the object without exposing the creation logic. 
            //In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate.
            //People usually use this pattern as the standard way to create objects

            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();

            #endregion

            #region DependencyInjection

            //Dependency Injection(DI) is a software design pattern. It allows us to develop loosely-coupled code.
            //Dependency Injection is to make code maintainable & helps to reduce the tight coupling among software components
            //Dependency Injection reduces the hard - coded dependencies among your classes by injecting those dependencies at run time 
            //reduces class coupling ; increase code reuse ;improve code maintainability, improve application testing and Make unit testing Possible.

            constructorinjection cs = new constructorinjection(new format());
            cs.print();

            client cn = new client();
            cn.run(new servic());

            #endregion

            #region SingleTon Pattern

            Calculate.Instance.ValueOne = 10.5;
            Calculate.Instance.ValueTwo = 5.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.WriteLine("\n----------------------\n");
            Calculate.Instance.ValueTwo = 10.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.ReadLine();

            #endregion

            #endregion

            veranda();

            #region Encapsulation

            EncapsulationDemo objDemo = new EncapsulationDemo();
            Aperture objAperture = new Aperture();
            parentClass objparentClass = new parentClass();
            ChildClass objChildClass = new ChildClass();

            Console.WriteLine(objDemo.Mark); // Output For EncapsulationDemo
            Console.WriteLine(objAperture.GetVolume()); //Output For Aperture 

            #endregion

        } // Main function Ends here

        #region GetHighScore

        private List<int> scoreList;
        private List<int> rankedScores;

        public void HighScores(List<int> list)
        {
            this.scoreList = list;

            var orderedScoresEnumerable = from s in scoreList orderby s descending select s;
            this.rankedScores = orderedScoresEnumerable.ToList();
        }

        public List<int> Scores()
        {
            return this.scoreList;
        }

        public int Latest()
        {
            return this.scoreList[this.scoreList.Count - 1];
        }

        public int PersonalBest()
        {
            return this.rankedScores[0];
        }

        public List<int> PersonalTopThree()
        {
            List<int> topThree = new List<int> { };
            int i = 0;
            while (this.rankedScores.Count > i && topThree.Count < 3)
            {
                topThree.Add(this.rankedScores[i]);
                i++;
            }
            return topThree;
        }

        #endregion

        #region GetRessistorColor
        public static class ResistorColor
        {
            private static string[] colors = Colors();

            public static int ColorCode(string color)
            {
                return Array.IndexOf(colors, color);
            }

            public static string[] Colors() => new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        }

        #endregion

        #region CircularBuffer
        public class CircularBuffer<T>
        {
            private Queue<T> buffer;
            private int number;
            public CircularBuffer(int capacity)
            {
                buffer = new Queue<T>(capacity);
                number = capacity;
            }

            public T Read() => buffer.Dequeue();

            public void Write(T value)
            {
                if (buffer.Count == number)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    buffer.Enqueue(value);
                }
            }

            public void Overwrite(T value)
            {
                if (buffer.Count == number)
                {
                    buffer.Dequeue();
                    buffer.Enqueue(value);
                }
                else
                {
                    buffer.Enqueue(value);
                }
            }

            public void Clear() => buffer.Clear();
        }

        #endregion

        public static class ReverseString
        {
            public static string Reverse(string input)
            {
                var reverseStringBuilder = new StringBuilder();
                for (int i = input.Length - 1; i > -1; i--)
                {
                    reverseStringBuilder.Append(input[i]);
                }
                return reverseStringBuilder.ToString();
            }
        }
        public static class SumOfMultiples
        {
            public static int Sum(IEnumerable<int> multiples, int max) =>
                Enumerable.Range(1, max - 1)
                    .Where(n => n < max && multiples
                        .Where(m => m > 0)
                        .Count(m => n % m == 0) > 0)
                    .Sum();
        }
    }
    public static class Series
    {
        public static string[] Slices(string numbers, int sliceLength)
        {
            if (sliceLength > numbers.Length || sliceLength < 1 || numbers.Length < 1)
                throw new ArgumentException();
            return (from i in Enumerable.Range(0, numbers.Length - sliceLength + 1)
                    select (new string(numbers.Skip(i).Take(sliceLength).ToArray()))).ToArray<string>();
        }
    }
}

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int iExtensionMtd, int value)
        {
            return iExtensionMtd > value;
        }
    }
}
