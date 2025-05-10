using UnityEngine;
using NaughtyAttributes;
using UnityEngine.UI;

public class EvidenceTableScript : MonoBehaviour
{
    [SerializeField][Foldout("Basics")]EvidenceList evidenceList;
    [SerializeField] [Foldout("Basics")] private Image[] itemSlots;

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
}
