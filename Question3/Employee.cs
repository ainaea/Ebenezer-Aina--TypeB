using System;

namespace Question3
{
    public class Employee : IPayable
    {
        public string MailingAddress { get; set; }

        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set {
                    if (value > 0)
                    {
                        salary = value;
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException("Negative earning detected");
                    }
                }
        }

        public decimal RetrieveAmount()
        {
            return Salary;
        }

        public void AddToAmountDue(double bonus)
        {
            if (bonus > 0)
            {
                Salary += bonus;                
            }else
            {
                Console.WriteLine("Attempt to add invalid amount detected");
            }
        }

        public string PaymentAddress()
        {
            return MailingAddress;
        }
        
    }
}