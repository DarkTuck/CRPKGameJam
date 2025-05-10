using UnityEngine;
using UnityEngine.UI;

public enum EvidenceStatus
{
    unFound,
    unExplored,
    explored,
}
[CreateAssetMenu(fileName = "EvidenceObject", menuName = "Scriptable Objects/EvidenceObject")]
public class EvidenceObject : ScriptableObject
{
    public Sprite objectImage;
    public EvidenceStatus status=EvidenceStatus.unFound;
    public string description="";
}
