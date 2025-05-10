using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class TableObjectText : MonoBehaviour
{
    [SerializeField] EvidenceTableScript evidenceTable;
    [SerializeField] StringEvent stringEvent;

    void Awake()
    {
        evidenceTable ??= GameObject.FindGameObjectWithTag("EvidenceTable").GetComponent<EvidenceTableScript>();
    }
    public void GetInfo()
    {
        stringEvent.TextValue= evidenceTable.ReturnInfo(this.GetComponent<Image>());
    }
}
