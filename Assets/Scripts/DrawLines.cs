using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coords point = new Coords(10,20);
    
    Coords yAxisStartPoint = new Coords(0,100);
    Coords yAxisEndPoint = new Coords(0,-100);
    
    Coords xAxisStartPoint = new Coords(-160,0);
    Coords xAxisEndPoint = new Coords(160,0);
    
    
    void Start()
    {
        Debug.Log(point.ToString());
        Coords.DrawPoint(point, 2, Color.blue);
        Coords.DrawLine(yAxisStartPoint, yAxisEndPoint, 0.4f, Color.green);
        Coords.DrawLine(xAxisStartPoint, xAxisEndPoint, 0.4f, Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
