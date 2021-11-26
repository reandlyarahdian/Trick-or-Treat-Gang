using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Flower", menuName ="Flower")]
public class PointSO : ScriptableObject
{
    public Color color;
    public int point;
    public string taging;
    public float seconds;
}
