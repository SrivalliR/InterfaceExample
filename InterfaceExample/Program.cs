using System;

namespace InterfaceExample
{
    interface I1
    {
        
        void Employeedetails();
        //int add(int a, int b);
        //int add(int a, int b, int c);
        int EmpID { get; set ; }
        string EmpName { get; set; }

    }
    interface I2
    {
        void print();
    }

    class Baseclass : I2 
    {
        public virtual void print()
        {
            Console.WriteLine("Base Class method");
        }
    }
    class Derivedclass : Baseclass
    {
        //Constant variables van be initialised at declaration only and
        //can be called with classname only (classname:variablename)
        //The value of Const variable cannot be changed.
        public const int variableConst = 5000;

        //Static variable can be initiablized anywhere but only one copy is available and
        //the same is shared to all the objects.
        //If any changes made to the variable reflects to all the objects.
        //It is called with classname (classname:staticvariable).
        public static int variableStaic;

        //Readonly variable can be initialised either at declaration or in a constructor only.
        //can be called with object name. (der.variableReadOnly)
        public readonly int variableReadOnly;

        public Derivedclass()
        {
            variableReadOnly = 1000;
        }


    
     new void print()
        {
            
            Console.WriteLine("Derived Base Class method ");
        }
        public void Print()
        {
            Console.WriteLine("second print in derived class");
        }
        
    }
    public class Employee : I1
    {
        //public int EmpID { get { return EmpID; }set { EmpID = 101; }}
        //public string EmpName { get { return EmpName; } set {EmpName="Rahini"; } }
        //public string EmpName = "Hi";

        //If we r not going to implement give below exception
        // public int empID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public static int a=1;
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        //private int empId;
        //public int EmpID { get { return this.empId = EmpID; } set { this.empId = EmpID; } }
        //private string _empName;
        //public string EmpName { get { return _empName; } set { _empName = EmpName; } }
        public void Employeedetails()
        {
            Console.WriteLine("Employee Name= ", EmpName);
            Console.WriteLine("EmployeeID {0}=", EmpID);
            Console.WriteLine("{0}", EmpID, EmpName);
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.EmpID = 101;
            //emp.EmpName = "Rahini";
            ////emp.Employeedetails();
            //Console.WriteLine("Empid={0}",emp.EmpID);
            //Console.WriteLine("EmpNAme= {0}", emp.EmpName);
            //int b = 10;

           // Console.WriteLine("{0}", b);

            Baseclass bas = new Baseclass();
            bas.print();
            Baseclass bas1 = new Derivedclass();
            bas1.print();
           
            Derivedclass der = new Derivedclass();
            
            der.print();
            der.Print();
            
            
           // Console.WriteLine("a= {0}");
            //Derivedclass.a = 100;
            
            Console.WriteLine("a= {0}", Derivedclass.variableConst);
            Derivedclass.variableStaic = 8000;
            Console.WriteLine("a= {0}", Derivedclass.variableStaic);
            Console.WriteLine("a= {0}", der.variableReadOnly);



        }
    }
}
