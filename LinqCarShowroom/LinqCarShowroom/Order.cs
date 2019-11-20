namespace LinqCarShowroom
{
    /// <summary>
    /// Provide simple view of purchase car.
    /// </summary>
    public class Order
    {
        /// <summary> Constructor with paramaters. </summary>
        /// <param name="model"> Model of car. </param>
        /// <param name="fullName"> Full Name of purchaser. </param>
        /// <param name="telephone"> Telephone of purchaser. </param>
        public Order(string model, string fullName, string telephone)
        {
            Model = model;
            FullName = fullName;
            Telephone = telephone;
        }

        /// <summary> Model of car. </summary>
        public string Model { get; }

        /// <summary> Full Name of purchaser. </summary>
        public string FullName { get; }

        /// <summary> Telephone of purchaser. </summary>
        public string Telephone { get; }
    }
}