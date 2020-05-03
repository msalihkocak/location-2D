using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords
{
    private float x;
    private float y;
    private float z;

    public Coords(float x, float y)
    {
        this.x = x;
        this.y = y;
        this.z = -1;
    }

    public Vector3 GetAsVector3()
    {
        return new Vector3(this.x, this.y, this.z);
    }

    public static void DrawPoint(Coords position, float width, Color color)
    {
        var line = new GameObject("Point_" + position.ToString());
        var lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.SetPosition(0, new Vector3(position.x - width / 3.0f, position.y - width / 3.0f, position.z));
        lineRenderer.SetPosition(1, new Vector3(position.x + width / 3.0f, position.y + width / 3.0f, position.z));
        SetLineRenderDefaultParams(lineRenderer, color, width);
    }

    public static void DrawLine(Coords startPosition, Coords endPosition, float width, Color color)
    {
        var line = new GameObject("Line_" + startPosition.ToString() + " - " + endPosition.ToString());
        var lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.SetPosition(0, startPosition.GetAsVector3());
        lineRenderer.SetPosition(1, endPosition.GetAsVector3());
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
        return "(" + x + "," + y + "," + z + ")";
    }
}
