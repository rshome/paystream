using PaystreamExpenses;

namespace PaystreamExpenses
{
    public class LatestWeek
    {
        public static void Main(string[] args)
        {            
            Driver wd = new Driver();            

            wd.Login();
            wd.SelectAccountandExpenses();            
            
            // enter amount in input box by ALT+TAB screen switch.
            wd.DeclarePhoneCalls();         
            wd.Broadband();            
           
            for (int i = 0; i < 5; i++)
            {
                wd.DeclareExpensesDriveMS();
            }
            
            
            for (int i = 0; i < 5; i++)
            {
                wd.DeclareExpensesBreakfast();
            }

            
            for (int i = 0; i < 5; i++)
            {
                wd.DeclareExpensesLunch();
            }

            
            for (int i = 0; i < 5; i++)
            {
                wd.DeclareExpensesCoffee();
            }
           
            /*       
            for (int i = 0; i < 5; i++)
            {
                wd.DeclareExpensesParking();
            } 

            for (int i = 0; i < 5; i++)
            {
                wd.DeclareExpensesDriveHemel();
            }
            */
        }
    }
}
