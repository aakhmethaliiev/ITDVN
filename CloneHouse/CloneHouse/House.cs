namespace CloneHouse
{
    /// <summary>
    /// Class which provide House with address and number of flows.
    /// </summary>
    public class House
    {
        /// <summary> Constructor with parameters. </summary>
        /// <param name="address"> Address of the house </param>
        /// <param name="numberOfFlows"> Number of flows in the house. </param>
        public House(string address, int numberOfFlows)
        {
            Address = address;
            NumberOfFlows = numberOfFlows;
        }

        /// <summary> Surface clone. </summary>
        /// <returns> New instance of House. </returns>
        public House Clone()
        {
            return new House(Address, NumberOfFlows);
        }

        /// <summary> Deep clone. </summary>
        /// <returns> Clone of this object. </returns>
        public House DeepClone()
        {
            return MemberwiseClone() as House;
        }

        public override string ToString()
        {
            return string.Format($"Adress - {Address}; Number of flows - {NumberOfFlows};");
        }

        /// <summary> Address of the house. </summary>
        public string Address { get; set; }

        /// <summary> Number of flows in the house. </summary>
        public int NumberOfFlows { get; set; }
    }
}