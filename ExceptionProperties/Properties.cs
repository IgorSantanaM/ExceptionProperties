using System;

class Properties
{
    static void Main()
    {
        try
        {
            Method1();
        } // end try
        catch (Exception exceptionParameter)
        {
            // output the string representation of the Exception, then output
            // properties Message, StackTrace and InnerException
            Console.WriteLine("exceptionParameter.ToString: \n{0}\n", exceptionParameter.ToString());
            Console.WriteLine("exceptionParameter.Message: \n{0}\n", exceptionParameter.Message);
            Console.WriteLine("exceptionParameter.StackTrace: \n{0}\n", exceptionParameter.StackTrace);
            Console.WriteLine("exceptionParameter.InnerException: \n{0}\n", exceptionParameter.InnerException);
        } // end catch
    } // end method Main

    // calls Method2
    static void Method1()
    {
        Method2();
    } // end method Method1

    static void Method2()
    {
        Method3();
    } // end method Method2

    static void Method3()
    {
        try
        {
            Convert.ToInt32("Not an integer");
        } // end try
        catch (FormatException formatExceptionParameter)
        {
            // wrap FormatException in new Exception
            throw new Exception("Exception occurred in Method3", formatExceptionParameter);
        } // end catch
    } // end method Method3
} // end class Properties
