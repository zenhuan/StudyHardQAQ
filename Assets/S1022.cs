using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1022 : MonoBehaviour
{
   //˜‹Ôìº¯”µµÄŒWÁ•


    void Start()
    {
        Point2D position = new Point2D(3,9);
        print(position.x);

    }

   
}

public class Point2D
{
    public float x;
    public float y;
    public Point2D(int x , int y)
    {
        this.x = x;
        this.y = y;
    }
}
