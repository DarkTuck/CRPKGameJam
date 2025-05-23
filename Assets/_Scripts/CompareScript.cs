using System;
using UnityEngine;
using UnityEngine.UI;

public class CompareScript : MonoBehaviour
{
    [SerializeField]EvidenceTableScript evidenceTable;
    [SerializeField]StringEvent output;
    private GameObject firstObject;
    
    public void Select(GameObject obj)
    {
        if (obj.CompareTag("Evidence"))
        {
            if (evidenceTable.GetEvidenceObject(obj.GetComponent<Image>()).status == EvidenceStatus.UnFound)
            {
                return;
            }
        }
        if (firstObject == obj)
        {
            UnselectFirstObject();
            return;
        }

        if (obj.CompareTag("Owner") && !firstObject)
        {
            UnselectFirstObject();
            output.TextValue = "Najpierw wybierz dowód";
            return;
        }

        if (!firstObject)
        {
            if (evidenceTable.GetEvidenceObject(obj.GetComponent<Image>()).status == EvidenceStatus.Explored)
            {
                return;
            }
            firstObject = obj;
            var outline = obj.GetComponent<Outline>() ? obj.GetComponent<Outline>() : obj.AddComponent<Outline>();
            outline.effectColor = Color.gold;
            outline.effectDistance = new Vector2(2f, 2f);
            outline.enabled = true;
            return;
        }

        if (firstObject)
        {
            Compare(firstObject,obj);
        }
        //Debug.Log(firstObject.name);
        //Debug.Log(obj.name);
    }

    void Compare(GameObject selected, GameObject target)
    {
        var selectedEvidence = evidenceTable.GetEvidenceObject(selected.GetComponent<Image>());
        switch (target.tag)
        {
            case "Evidence":
                CompareToEvidence(selectedEvidence,evidenceTable.GetEvidenceObject(target.GetComponent<Image>()));
                break;
            case "Owner":
                CompareToOwner(selectedEvidence,target.GetComponent<GetOwner>().owner);
                break;
        }
    }
    void CompareToOwner(EvidenceObject evidence, Owner owner)
    {
        if (evidence.owner == owner)
        {
            SuccesfullCompare(evidence);
            return;
        }
        UnselectFirstObject();
        output.TextValue = "";
    }

    void CompareToEvidence(EvidenceObject evidence, EvidenceObject evidence2)
    {
        if (evidence.connectedObject == evidence2)
        {
            SuccesfullCompare(evidence);
            return;
        }
        UnselectFirstObject();
        output.TextValue = "";
    }
    void SuccesfullCompare(EvidenceObject evidence)
    {
        evidence.status = EvidenceStatus.Explored;
        evidenceTable.CurrentEvidenceCount++;
        UnselectFirstObject();
        output.TextValue = "znaleziono połączenie";
    }

    void UnselectFirstObject()
    {
        if (firstObject.GetComponent<Outline>())
        {
            firstObject.GetComponent<Outline>().enabled = false;
        }
        firstObject = null;
        evidenceTable.DisplayEvidenceTable();
    }
    
    
}
