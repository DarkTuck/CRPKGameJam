using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[CreateAssetMenu(fileName = "EvidenceList", menuName = "Scriptable Objects/EvidenceList")]
public class EvidenceList : ScriptableObject
{
    public EvidenceObject[] evidenceObjectList;
}
