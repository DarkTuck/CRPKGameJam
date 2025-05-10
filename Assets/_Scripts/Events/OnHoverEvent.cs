using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class OnHoverEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]UnityEvent onHoverEnter,onHoverExit;

    public void OnPointerEnter(PointerEventData eventData)
    {
        onHoverEnter.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onHoverExit.Invoke();
    }
}
