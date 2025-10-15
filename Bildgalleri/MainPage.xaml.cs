namespace Bildgalleri;
using System.Collections.Generic;



public partial class MainPage : ContentPage
{
    public class ImageItem
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public string Beskrivning { get; set; }
    }


    public List<ImageItem> Images { get; set; }
    private Random random = new();


    public MainPage()
    {
        InitializeComponent();



        Images = new List<ImageItem>
        {
            new ImageItem { Id = 1, Image = "image1.jpg", Beskrivning = "En man" },
            new ImageItem { Id = 2, Image = "image2.jpg", Beskrivning = "Statue of liberty"},
            new ImageItem { Id = 3, Image = "image3.jpg", Beskrivning = "Pyramids"},
            new ImageItem { Id = 4, Image = "image4.jpg", Beskrivning = "En hund"},
            new ImageItem { Id = 5, Image = "image5.jpg", Beskrivning = "Nordstan"},
            new ImageItem { Id = 6, Image = "image6.jpg", Beskrivning = "Bird"},
            new ImageItem { Id = 7, Image = "image7.jpg", Beskrivning = "En kvinna"},
            new ImageItem { Id = 8, Image = "image8.jpg", Beskrivning = "En bil"},
            new ImageItem { Id = 9, Image = "image9.jpg", Beskrivning = "Eiffel tower"},
            new ImageItem { Id = 10, Image = "image10.jpg", Beskrivning = "A waterfall"},
        };
    }
    private void ShowImageAndText()
    {
        int index = random.Next(Images.Count);
        var selectedImage = Images[index];

        MainImage.Source = selectedImage.Image;
        ImageText.Text = selectedImage.Beskrivning;

    }

    private void ImageOnClicked(object? sender, EventArgs e)
    {
        ShowImageAndText();
    }


}
