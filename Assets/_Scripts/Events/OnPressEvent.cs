using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class OnPressEvent : MonoBehaviour
{
    private Actions action;
    [SerializeField]UnityEvent onPress;

    void Awake()
    {
        action = new Actions();
    }
    public void EnableInput()
    {
        action.Enable();
        action.Player.Interact.performed += Press;
    }

    private void Press(InputAction.CallbackContext obj)
    {
        onPress.Invoke();
    }

    public void DisableInput()
    {
        action.Disable();
        action.Player.Interact.performed -= Press;
    }
}
