using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinates
{
    private float _x;
    private float _y;
    private readonly float _z;

    public Coordinates(float x, float y)
    {
        this._x = x;
        this._y = y;
        this._z = -1;
    }

    public float X
    {
        get => _x;
        set => _x = value;
    }

    public float Y
    {
        get => _y;
        set => _y = value;
    }

    public Vector3 GetAsVector3(float marginZ = 0)
    {
        return new Vector3(this._x, this._y, this._z + marginZ);
    }

    public static void DrawPoint(Coordinates position, float width, Color color)
    {
        var line = new GameObject("Point_" + position.ToString());
        var lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.SetPosition(0, new Vector3(position._x - width / 3.0f, position._y - width / 3.0f, position._z));
        lineRenderer.SetPosition(1, new Vector3(position._x + width / 3.0f, position._y + width / 3.0f, position._z));
        SetLineRenderDefaultParams(lineRenderer, color, width);
    }

    public static void DrawLine(Coordinates startPosition, Coordinates endPosition, float width, 
        Color color, float marginZ = 0)
    {
        var line = new GameObject("Line_" + startPosition.ToString() + " - " + endPosition.ToString());
        var lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.SetPosition(0, startPosition.GetAsVector3(marginZ));
        lineRenderer.SetPosition(1, endPosition.GetAsVector3(marginZ));
        SetLineRenderDefaultParams(lineRenderer, color, width);
    }

    private static void SetLineRenderDefaultParams(LineRenderer lineRenderer, Color color, float width)
    {
        lineRenderer.material = new Material(Shader.Find("Unlit/Color")) {color = color};
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }

    public override string ToString()
    {
        return "(" + _x + "," + _y + "," + _z + ")";
    }
}
