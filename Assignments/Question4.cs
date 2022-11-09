using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question4
    {
       static string userName = " ";
       static string accountType = " ";
       static double savingRate = 5.5;
       static double currentRate = 4.5;


        public static double getSavingRate()
        {
            return savingRate;
        }

        public static double getCurrentRate()
        {
            return currentRate;
        }

        public static string getUserName()
        {
            return userName;
        }

        public static string getAccountType()
        {
            return accountType;
        }

        public static void setUserName(string uName)
        {
            userName = uName;
        }

        public static void setAccountType(string aType)
        {
            accountType = aType;    
        }

        public static void setCurrentRate(double cRate)
        {
           currentRate = cRate;
        }

        public static void setSavingRate(double sRate)
        {
            savingRate = sRate;
        }
    }

    class BankAccount : Question4
    {
        public void openBankAccount(string uName,string aType)
        {
            setUserName(uName);
            setAccountType(aType);
        }
    }

    class Customer : BankAccount
    {
        public Customer()
        {
            Console.WriteLine(" User Name : " + getUserName());
            Console.WriteLine(" Account type : " + getAccountType());
        }

        public void calculateSavingInterest(int p, int n)
        {
            Console.WriteLine("For saving Account");
            double sRate=(p*n*getSavingRate())/100; 
                
            //setSavingRate(sRate);
            Console.WriteLine(" Rate of Interest on Savings : " + getSavingRate());
        }

        public void calculateCurrentRate(int p,int n)
        {
            Console.WriteLine("For Current Account");
            double cRate = (p * n * getCurrentRate())/100;

            setCurrentRate(cRate);
            Console.WriteLine(" Rate of Current on Current : " + getCurrentRate());
        }
    }
}
