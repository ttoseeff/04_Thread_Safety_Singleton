// See https://aka.ms/new-console-template for more information
using _04_Thread_Safety_Singleton;

Console.WriteLine("Sigleton Program");
Parallel.Invoke(new Action(() => PrintStudentDetails()), new Action(() => PrintEmployeeDetails()));

static void PrintStudentDetails()
{
    Singleton FromStudent = Singleton.Instance;
    FromStudent.PrintDetails("From Student");
}

static void PrintEmployeeDetails()
{
    Singleton FromEmployee = Singleton.Instance;
    FromEmployee.PrintDetails("From Employee");
}

/*
 * why we should use sealed keyword in the singleton class
 * 
 *Singleton.SingletonDerived singletonDerived = new Singleton.SingletonDerived();
 *singletonDerived.PrintDetails("Derived Class");
 *
 */