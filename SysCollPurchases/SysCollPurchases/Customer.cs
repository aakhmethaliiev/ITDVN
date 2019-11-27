namespace SysCollPurchases
{
    public class Customer
    {
        /// <summary> Constructor with parameters. </summary>
        /// <param name="fullName"> Full Name of customer. </param>
        public Customer(string fullName)
        {
            FullName = fullName;
        }

        /// <summary> Full Name of customer. </summary>
        public string FullName { get; }
    }
}