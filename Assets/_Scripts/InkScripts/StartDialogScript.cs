using UnityEngine;

public class StartDialogScript : MonoBehaviour
{
    [SerializeField] TextAsset dialogTextAsset;

    public void StartDialog()
    {
        InkDialogManager.OpenDialogue(dialogTextAsset);
    }
    
}
