namespace AssigmentOOPC_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Abstraction is the process of exposing only what the user needs and hiding how it is implemented.

             Focus on what an object does, not how it does it
             Reduces complexity — caller sees a simple contract
             Improves maintainability — change internals without breaking callers
             Abstraction vs Encapsulation
             Aspect	       Abstraction	                       Encapsulation
             Main          Focus What an object does	       How data is protected
             Hides	       Implementation complexity	       Internal state / data
             Tools	       Interface, Abstract class	       Access modifiers Properties
             Level	       Design level	                       Implementation level
            

            EXample:

            

            */

            //Login login = new FacebookLogin();

            //login.login();



            //abstract class Login
            //{
            //    public abstract void login();

            //}
            //class GoogleLogin : Login
            //{
            //    public override void login()
            //    {
            //        Console.WriteLine("Login with Google");
            //    }
            //}

            //class FacebookLogin : Login
            //{
            //    public override void login()
            //    {
            //        Console.WriteLine("Login with Facebook");
            //    }
            //}
            //class UsernamePasswordLogin : Login
            //{
            //    public override void login()
            //    {
            //        Console.WriteLine("Login with Username & Password");
            //    }
            //}

            //public class Login
            //{
            //    private string passsword;
            //    private int accountnumber;
            //    public string Namee;

            //    public int Accountnumber { get; set; }
            //    public string Password
            //    {
            //        get
            //        {
            //            return passsword;
            //        }

            //        set
            //        {
            //            if (value.Length >= 8)
            //            {
            //                passsword = value;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Password must be at least 8 characters.");
            //            }
            //        }





            //    }
            //}


            #endregion

            #region Q2
            /*
             
             Abstract Class represents "What you are." It provides shared implementation, can contain fields, constructors, and implemented methods, and a class can inherit from only one abstract class.
             Interface represents "What you can do." It defines a contract (capability), does not contain fields or constructors, and a class can implement multiple interfaces.
             When to choose each one?
             Choose an Abstract Class when related classes share common data and behavior, and you want to provide a common implementation.
             Choose an Interface when you want to define a common capability or contract that can be implemented by different classes, or when you need multiple implementations and loose coupling.
             
            */
            #endregion

            #region Q3
            /*
            a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
            Answer:No Abstract classes cannot be instantiated directly. They must be inherited by a derived class
            b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?
            Answer:PowerConsumption()===>Abstract Method
            Status()===>Virtual Method
            Label()====>Concatre Methods
            c) If you call Status() on a Toaster object, what will it return? Why?
            Answer:"Standby" ===>because value defualt

             
            */
            #endregion

        }


    }
}



             

