public class ImageTracker
{
    public static ImageTracker Instance = new ImageTracker();
    private ImageTracker()
    {
        
    }

    public string currentImage { get; set; } = "null";
}