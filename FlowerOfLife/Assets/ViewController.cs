using UnityEngine;
using System.Collections;

public class ViewController : MonoBehaviour 
{
    public bool switchBackground = false;
    public bool zoomIn = false;
    public bool zoomOut = false;

    bool color = true;
    int minZoomSize = 5; 
    int maxZoomSize = 25;

	void Update () 
    {
        if (switchBackground) 
        {
            switchBackground = false;
            color = !color;

            camera.backgroundColor = getColor(color);
        }

        if (zoomIn)
        {
            zoomIn = false;
            ZoomIn();
        }
        else if (zoomOut)
        {
            zoomOut = false;
            ZoomOut();
        }
	}

    Color getColor(bool color)
    {
        return color ? Color.black : Color.white;
    }

    void ZoomIn()
    {
        camera.orthographicSize--;
        if (camera.orthographicSize < minZoomSize) camera.orthographicSize = minZoomSize;

    }

    void ZoomOut()
    {
        camera.orthographicSize++;
        if (camera.orthographicSize > maxZoomSize) camera.orthographicSize = maxZoomSize;
    }
}
