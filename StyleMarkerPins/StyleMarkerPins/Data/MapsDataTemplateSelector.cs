namespace StyleMarkerPins
{
    public class MapsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? HighPopulationTemplate { get; set; }

        public DataTemplate? LowPopulationTemplate { get; set; }

        protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
        {
            return ((CustomMarker)item).Population >= 250 ? HighPopulationTemplate : LowPopulationTemplate;
        }
    }
}
