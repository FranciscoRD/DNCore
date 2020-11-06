using System;
using System.Collections.Generic;

namespace Cap12.Interfaces
{
    public class PayableInterfaceTest
    {
        public static void Principal()
        {
            var payableObjects = new List<IPayable>(){
                new Invoice("01234","seat",2,375.00M),
                new Invoice("56789","tire",4,79.95M),
                new SalariedEmployee("John","Smith","111-11-1111",800.00M),
                new SalariedEmployee("Lisa","Barnes","888-88-8888",1200.00M)};

            Console.WriteLine("Invoice and Employees processed polymorphically:\n");

            foreach (var payable in payableObjects)
            {
                Console.WriteLine($"{payable}");
                Console.WriteLine($"Payment due: {payable.GetPaymentAmount():C}\n");
            }
        }
    }
}