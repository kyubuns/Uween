﻿using UnityEngine;
using System.Collections;

public class TweenSXYZ : TweenVec3S<TweenSXYZ>
{
    public static TweenSXYZ Add(GameObject g, float duration, Vector3 to)
    {
        return Add<TweenSXYZ>(g, duration, to);
    }
    
    public static TweenSXYZ Add(GameObject g, float duration, float toSX, float toSY, float toSZ)
    {
        return Add<TweenSXYZ>(g, duration, toSX, toSY, toSZ);
    }
    
    public static TweenSXYZ Add(GameObject g, float duration, float toSXYZ)
    {
        return Add(g, duration, toSXYZ, toSXYZ, toSXYZ);
    }
}
