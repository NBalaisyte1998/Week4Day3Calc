using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandling EH = new ExceptionHandling();
            EH.Divide(12,4);
            EH.Divide(8, 0);

        }
    }
    public class ExceptionHandling
    {
        //Error, Exception, Try--Catch--finally, throw and throwing, using
        public void Divide(int num1, int num2)
        {
            int value1 = num1;
            int value2 = num2;
            using ()
            {

            }
                // wrapping the fauly code into Try
                try
                {
                    if (value2 == 0)
                    {
                        throw new Eng40DivideByZeroException();
                    }
                    // create connection object and now in memory
                    //program crashed 
                    int answer = value1 / value2;
                    Console.WriteLine(answer);
                }
                catch (Eng40DivideByZeroException ex)
                //insert class
                // if the error occurs then .net creates an object of the error
                // and stores it there, you can do whatever you want with it
                {
                    ex.PrintMessage();
                }
                catch (MissingFieldException ms)
                {
                    Console.WriteLine(ms.Message);
                }
                catch (MissingMethodException mes)
                {
                    Console.WriteLine(mes.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); // safety net, catches all the exceptions
                }
                finally
                {
                    Console.WriteLine("I am cleaning after myself");
                    Console.WriteLine("Freeing up memory allocated for object");
                }
            // throw and throwinf 
        }
    }
    public class Eng40DivideByZeroException : Exception
    {
        public void PrintMessage()
        {
            // this is an error in medical science that dot net doesnt know about
            Console.WriteLine("I think you are trying to divide by 0, its mathematically wrong");
        }
    }
}
