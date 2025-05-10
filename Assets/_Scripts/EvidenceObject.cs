using UnityEngine;
using UnityEngine.UI;

public enum EvidenceStatus
{
    unFound,
    unExplored,
    explored,
}

public enum Owner
{
    Owner1,Owner2,Owner3,Owner4,Owner5
}
[CreateAssetMenu(fileName = "EvidenceObject", menuName = "Scriptable Objects/EvidenceObject")]
public class EvidenceObject : ScriptableObject
{
    public Sprite objectImage;
    public EvidenceStatus status=EvidenceStatus.unFound;
    public Owner owner;
    public string description="";
    public EvidenceObject connectedObject;
}
