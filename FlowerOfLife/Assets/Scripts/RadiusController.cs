using UnityEngine;
using System.Collections;

public class RadiusController : MonoBehaviour 
{
    public GameObject originPoint;
    public GameObject markerPoint;
    public float radius;
    public float speed;
    public bool stopped = false;

    private float currentRadius;

    void Start()
    {
        currentRadius = radius;
        SetUp();
    }

    void SetUp()
    {
        transform.position = Vector3.zero;
        transform.localScale = new Vector3(0.1f, currentRadius, 0.1f);
        transform.position = new Vector3(originPoint.transform.position.x, currentRadius / 2f, 0f);
        markerPoint.transform.position = new Vector3(0f, currentRadius, 0f);
        markerPoint.transform.parent = transform;
        markerPoint.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        stopped = false;
    }

    void Update()
    {
        if (currentRadius != radius)
        {
            stopped = true;
            currentRadius = radius;
            SetUp();
        }
        if (!stopped)
        {
            transform.RotateAround(originPoint.transform.position, Vector3.forward, speed*10f * Time.deltaTime);

        }
    }
}
