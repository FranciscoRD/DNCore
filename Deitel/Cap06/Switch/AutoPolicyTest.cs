using System;

namespace Cap06.Switch
{
    public class AutoPolicyTest
    {
        public static void Principal()
        {
            AutoPolicy policy1 = new AutoPolicy(1111111,"Toyota Camry","NJ");
            AutoPolicy policy2 = new AutoPolicy(2222222,"Ford Fusion","ME");

            PolicyInNoFaultState(policy1);
            PolicyInNoFaultState(policy2);
        }        
        private static void PolicyInNoFaultState(AutoPolicy policy)
        {
            Console.WriteLine("The auto policy:");
            Console.Write($"Account #: {policy.AccountNumber}; ");
            Console.WriteLine($"Car: {policy.MakeAndModel};");
            Console.Write($"State {policy.State}; ");
            Console.Write($"{(policy.IsNoFaultState ? "is": "is not")}");
            Console.WriteLine(" a no-fault state\n");
        }
    }
}