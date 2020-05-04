using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coordinates point = new Coordinates(10,20);

    private readonly Coordinates _yAxisStartPoint = new Coordinates(0,100);
    private readonly Coordinates _yAxisEndPoint = new Coordinates(0,-100);
    
    private readonly Coordinates _xAxisStartPoint = new Coordinates(-160,0);
    private readonly Coordinates _xAxisEndPoint = new Coordinates(160,0);
    
    
    void Start()
    {
        Debug.Log(point.ToString());
        Coordinates.DrawPoint(point, 2, Color.blue);
        Coordinates.DrawLine(_yAxisStartPoint, _yAxisEndPoint, 0.4f, Color.green);
        Coordinates.DrawLine(_xAxisStartPoint, _xAxisEndPoint, 0.4f, Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
