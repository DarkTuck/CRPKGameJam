using UnityEngine;
using UnityEngine.UI;

public class Note : InteractiveObject
{
    [SerializeField] private GameObject noteImage;
    [SerializeField] private Button closeNoteButton;

    private void Start()
    {
        closeNoteButton.onClick.AddListener(OnNoteClosed);
    }
    protected override void OnObjectInteracted()
    {
        base.OnObjectInteracted();
        noteImage.SetActive(true);
    }
    private void OnNoteClosed(){
        noteImage.SetActive(false);
    }
}
