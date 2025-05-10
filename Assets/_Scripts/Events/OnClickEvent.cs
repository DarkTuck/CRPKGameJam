using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class OnClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]UnityEvent onClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        onClick.Invoke();
    }
}
