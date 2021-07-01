using System;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {

            }
            //from most custom to most base exception (first is executed firstly)
            catch(PersonalNotFoundExceptions customException)
            {

            }
            catch (ApplicationException ae)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw ex;  //changes track trace
            }
            finally
            {

            }
        }
    }
}
