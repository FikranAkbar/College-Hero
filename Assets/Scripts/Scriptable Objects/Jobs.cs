using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Job")]
public class Jobs : ScriptableObject
{
    public string jobName;
    public string clothReq;
    public int creativReq;
    public int IntelReq;
    [TextArea] public string jobDescription;
}
