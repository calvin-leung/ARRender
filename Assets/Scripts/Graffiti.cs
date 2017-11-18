using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graffiti
{
    public float latitude;
    public float longitude;
    public Drawing drawing;

    public Graffiti() {
    }

    public Graffiti(Drawing drawing, float latitude, float longitude) {
        this.drawing = drawing;
        this.latitude = latitude;
        this.longitude = longitude;
    }
}