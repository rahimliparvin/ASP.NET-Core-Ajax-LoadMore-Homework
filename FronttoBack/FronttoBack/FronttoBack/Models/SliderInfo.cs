namespace FronttoBack.Models
{
    public class SliderInfo : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public string? Active { get; set; }
        public int SliderId { get; set; }
        public Slider Slider { get; set; }

    

    }
}
