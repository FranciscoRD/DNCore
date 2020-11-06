namespace Cap06.Switch
{
    public class AutoPolicy
    {
        public int AccountNumber { get; set; }
        public string MakeAndModel { get; set; }
        public string State { get; set; }

        public AutoPolicy(int accounNumber, string makeAndModel, string state)
        {
            AccountNumber = accounNumber;
            MakeAndModel = makeAndModel;
            State = state;
        }
        public bool IsNoFaultState
        {
            get
            {
                bool noFaultState;
                switch (State)
                {
                    case "MA":
                    case "NJ":
                    case "NY":
                    case "PA":
                        noFaultState=true;
                        break;
                    default:
                        noFaultState = false;
                        break;
                }
                return noFaultState;
            }
        }
    }
}