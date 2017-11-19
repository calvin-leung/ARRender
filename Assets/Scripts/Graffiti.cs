using System.Collections.Generic;

public class Graffiti
{
    public float latitude;
    public float longitude;
    public List<Stroke> strokes;

    public Graffiti() {
    }

    public Graffiti(List<Stroke> strokes, float latitude, float longitude) {
        this.strokes = strokes;
        this.latitude = latitude;
        this.longitude = longitude;
    }
}