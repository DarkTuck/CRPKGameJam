using UnityEngine;
using System;
using NaughtyAttributes;
using Unity.VisualScripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class EvidenceTableScript : MonoBehaviour
{
    [SerializeField][Foldout("Basics")]EvidenceList evidenceList;
    [SerializeField] [Foldout("Basics")] private Image[] itemSlots;
    [SerializeField] String NotFoundAnswer;
    [SerializeField] String unExploerdAnswer;

    public void DisplayEvidenceTable()
    {
        for (int i = 0; i < evidenceList.evidenceObjectList.Length; i++)
        {
            switch (evidenceList.evidenceObjectList[i].status)
            {
                case EvidenceStatus.UnFound:
                    itemSlots[i].sprite=evidenceList.evidenceObjectList[i].objectImage;
                    itemSlots[i].color = Color.gray3;
                    break;
                case EvidenceStatus.UnExplored:
                    itemSlots[i].sprite=evidenceList.evidenceObjectList[i].objectImage;
                    if (!itemSlots[i].GetComponent<Outline>())
                    {
                        var outline = itemSlots[i].AddComponent<Outline>();
                        outline.effectColor = Color.red;
                        outline.effectDistance = new Vector2(2f, 2f); 
                    }
                    break;
                case EvidenceStatus.Explored:
                    var outline2 = itemSlots[i].GetComponent<Outline>();
                    if (outline2)
                    {
                        outline2.enabled=false;
                    }
                    itemSlots[i].sprite=evidenceList.evidenceObjectList[i].objectImage;
                    //itemSlots[i].color = Color.gray;
                break;
            }
        }
    }

    public String ReturnInfo(Image itemSlot)
    {
        int index;
        switch (evidenceList.evidenceObjectList[index = Array.IndexOf(itemSlots, itemSlot)].status)
        {
           case EvidenceStatus.UnExplored:
               return unExploerdAnswer;
           case EvidenceStatus.Explored:
               return evidenceList.evidenceObjectList[index].description;
           default:
               return NotFoundAnswer;
        }
    }

    public EvidenceObject GetEvidenceObject(Image itemSlot)
    {
       return evidenceList.evidenceObjectList[Array.IndexOf(itemSlots, itemSlot)];
    }
}
