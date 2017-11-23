using System.Collections.Generic;

public class Graffiti
{
	public string name;
	public float latitude;
	public float longitude;
	public List<Stroke> strokes;

	public Graffiti(List<Stroke> strokes, string name, float latitude, float longitude) {
		this.name = name;
		this.strokes = strokes;
		this.latitude = latitude;
		this.longitude = longitude;
	}
}