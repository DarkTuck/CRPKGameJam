using UnityEngine;
using UnityEngine.UI;

public class Note : InteractiveObject
{
    [SerializeField] GameObject noteImage;
    protected override void OnObjectInteracted()
    {
        base.OnObjectInteracted();
        noteImage.SetActive(true);
    }
}
