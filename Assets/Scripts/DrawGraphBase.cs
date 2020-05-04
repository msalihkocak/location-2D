using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraphBase : MonoBehaviour
{
    [SerializeField]
    private int size = 20;
    
    private readonly Coordinates _yAxisStartPoint = new Coordinates(0,100);
    private readonly Coordinates _yAxisEndPoint = new Coordinates(0,-100);
    
    private readonly Coordinates _xAxisStartPoint = new Coordinates(160,0);
    private readonly Coordinates _xAxisEndPoint = new Coordinates(-160,0);

    private void Start()
    {
        DrawGrid();
        DrawAxises();
    }

    private void DrawAxises()
    {
        Coordinates.DrawLine(_yAxisStartPoint, _yAxisEndPoint, 1, Color.green, -1);
        Coordinates.DrawLine(_xAxisStartPoint, _xAxisEndPoint, 1, Color.red, -1);
    }

    private void DrawGrid()
    {
        for (var i = size; i <= _yAxisStartPoint.Y; i+=size)
        {
            var upperStartPoint = new Coordinates(_xAxisStartPoint.X, i);
            var upperEndPoint = new Coordinates(_xAxisEndPoint.X, i);
            var lowerStartPoint = new Coordinates(_xAxisStartPoint.X, -i);
            var lowerEndPoint = new Coordinates(_xAxisEndPoint.X, -i);
            Coordinates.DrawLine(upperStartPoint, upperEndPoint, 0.4f, Color.grey);
            Coordinates.DrawLine(lowerStartPoint, lowerEndPoint, 0.4f, Color.grey);
        }
        
        for (var i = size; i <= _xAxisStartPoint.X; i+=size)
        {
            var upperStartPoint = new Coordinates(i, _yAxisStartPoint.Y);
            var upperEndPoint = new Coordinates(i, _yAxisEndPoint.Y);
            var lowerStartPoint = new Coordinates(-i, _yAxisStartPoint.Y);
            var lowerEndPoint = new Coordinates(-i, _yAxisEndPoint.Y);
            Coordinates.DrawLine(upperStartPoint, upperEndPoint, 0.4f, Color.grey);
            Coordinates.DrawLine(lowerStartPoint, lowerEndPoint, 0.4f, Color.grey);
        }
    }
}
