using UnityEngine;
using System;
using NaughtyAttributes;
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
                case EvidenceStatus.unFound:
                    itemSlots[i].sprite=evidenceList.evidenceObjectList[i].objectImage;
                    itemSlots[i].color = Color.gray3;
                    break;
                case EvidenceStatus.unExplored:
                    itemSlots[i].sprite=evidenceList.evidenceObjectList[i].objectImage;
                    itemSlots[i].color = Color.red;
                    break;
                case EvidenceStatus.explored:
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
           case EvidenceStatus.unExplored:
               return unExploerdAnswer;
           case EvidenceStatus.explored:
               return evidenceList.evidenceObjectList[index].description;
           default:
               return NotFoundAnswer;
        }
    }
}
