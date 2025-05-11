using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class InteractiveObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] protected Button objectArea;
    [SerializeField] protected Texture2D defaultCursor;
    [SerializeField] protected Texture2D newCursor;
    [SerializeField] protected AudioClip AudioClip;
    protected virtual void Start()
    {
        objectArea.onClick.AddListener(OnObjectInteracted);
    }
    protected virtual void OnObjectInteracted(){
        SetCursorTexture(defaultCursor);
        if (AudioClip != null)
        { 
            AudioPlayer.PlayClip(AudioClip);
        }
    }
    protected virtual void SetCursorTexture(Texture2D cursortexture){
        Cursor.SetCursor(cursortexture, Vector2.zero, CursorMode.Auto);
    }
    public void OnPointerEnter(PointerEventData eventData){
        SetCursorTexture(newCursor);
    }

    public void OnPointerExit(PointerEventData eventData){
        SetCursorTexture(defaultCursor);
    }
}
