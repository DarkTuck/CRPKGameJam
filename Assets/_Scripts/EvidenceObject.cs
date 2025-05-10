using UnityEngine;
using UnityEngine.UI;

public enum EvidenceStatus
{
    UnFound,
    UnExplored,
    Explored,
}

public enum Owner
{
    Jozef,Gabriela,Lucjan,Franciszek,Helena
}
[CreateAssetMenu(fileName = "EvidenceObject", menuName = "Scriptable Objects/EvidenceObject")]
public class EvidenceObject : ScriptableObject
{
    public Sprite objectImage;
    public EvidenceStatus status=EvidenceStatus.UnFound;
    public Owner owner;
    public string description="";
    public EvidenceObject connectedObject;
}
