using System.Text.Json.Serialization;

namespace Lab3_Task1_1_MauiApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Color { get; set; } = "#FF0000";

        [JsonIgnore]
        public Brush ColorBrush
        {
            get
            {
                return new SolidColorBrush(Microsoft.Maui.Graphics.Color.FromArgb(Color));
            }
        }

        public override string ToString() => $"{Title}";
    }
}