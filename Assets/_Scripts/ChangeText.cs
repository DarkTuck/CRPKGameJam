using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI attachedText;
    [SerializeField] private StringEvent stringEvent;

    private void OnEnable()
    {
        stringEvent.RegisterDelegate(DelegateChanged);
    }

    private void OnDisable()
    {
        stringEvent.UnregisterDelegate(DelegateChanged);
    }

    void DelegateChanged(bool isDebug)
    {
        attachedText.text = stringEvent.TextValue;
    }
}
