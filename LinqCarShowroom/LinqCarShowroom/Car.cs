namespace LinqCarShowroom
{
    /// <summary>
    /// Class which provide simple view of car.
    /// </summary>
    public class Car
    {
        /// <summary> Constructor with parameters. </summary>
        /// <param name="manufacturer"> Manufacturer of car. </param>
        /// <param name="model"> Model of car. </param>
        /// <param name="issueCar"> Year of issue of car. </param>
        /// <param name="color"> Color of car. </param>
        public Car(string manufacturer, string model, string issueCar, string color)
        {
            Manufacturer = manufacturer;
            Model = model;
            IssueCar = issueCar;
            Color = color;
        }

        /// <summary> Manufacturer of car. </summary>
        public string Manufacturer { get; }

        /// <summary> Model of car. </summary>
        public string Model { get; }

        /// <summary> Year of issue of car. </summary>
        public string IssueCar { get; }

        /// <summary> Color of car. </summary>
        public string Color { get; }
    }
}