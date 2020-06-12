using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Lecture")]
public class Lectures : ScriptableObject
{
    public string lectureType;
    public int lecturePoint;
    public string lectureSchedule;
    [TextArea] public string lectureDescription;
}
