namespace FronttoBack.Models
{
    public class Slider : BaseEntity
    {
        public string? Image { get; set; }

        ICollection<SliderInfo> Infos { get; set; }


    }
}
