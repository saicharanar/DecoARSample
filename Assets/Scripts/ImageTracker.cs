using Vector2 = UnityEngine.Vector2;

public class ImageTracker
{
    public static ImageTracker Instance = new ImageTracker();
    private ImageTracker()
    {
        
    }

    public string currentImage { get; set; } = "null";
    public Vector2 currentImageSize { get; set; } = Vector2.zero;
}