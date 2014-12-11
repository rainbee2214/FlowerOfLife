using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour 
{
    public float r, x, y;
    // x = rcos(theta)
    // y = rsin(theta)

    public float a = 1, b = 1, c = 0, d = 0;

    public float theta;
    public Vector2 position;
    public string currentFunction;
    public float speed = 1f;

    float speedRate = 0.005f;

	void Update () 
    {
        theta += speed*speedRate;
        r = function(theta, currentFunction);
        x = r * Mathf.Cos(theta);
        y = r * Mathf.Sin(theta);

        position.x = x;
        position.y = y;
        transform.position = position;
	}

    float function(float theta, string function)
    {
        float radius = 0f;
        switch (function)
        {
            case "constant":
            case "Constant": radius = Constant(theta);  break;
            case "sin":
            case "Sin": radius = a*Sin(b*theta + c) + d; break;
            default: radius = Constant(theta); break;
        }

        return radius;
    }

    float Constant(float theta)
    {
        return theta;
    }

    float Sin(float theta)
    {
        return Mathf.Sin(theta);
    }
}
