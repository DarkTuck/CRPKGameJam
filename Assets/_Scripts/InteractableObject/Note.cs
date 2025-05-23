using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Note : InteractiveObject
{
    [SerializeField] private GameObject noteImage;
    [SerializeField] private Button closeNoteButton;

    protected override void Start()
    {
        base.Start();
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
