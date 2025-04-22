namespace StyleMarkerPins
{
    using Syncfusion.Maui.Maps;

    public class CustomMarker : MapMarker
    {
        /// <summary>
        /// Gets or sets marker image for high population.
        /// </summary>
        public ImageSource HighPopulationMarker { get; set; }

        /// <summary>
        /// Gets or sets marker image for low population.
        /// </summary>
        public ImageSource LowPopulationMarker { get; set; }

        /// <summary>
        /// Gets or sets population (in million).
        /// </summary>
        public int Population { get; set; }

        public CustomMarker()
        {
            HighPopulationMarker = ImageSource.FromResource("StyleMarkerPins.PopulationMarkerPin1.png");
            LowPopulationMarker = ImageSource.FromResource("StyleMarkerPins.PopulationMarkerPin2.png");
        }
    }


}
