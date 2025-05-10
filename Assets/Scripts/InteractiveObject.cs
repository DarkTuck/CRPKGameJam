using UnityEngine;
using UnityEngine.UI;
public class InteractiveObject : MonoBehaviour
{
    [SerializeField] private Button button;
    private void Start()
    {
        button.onClick.AddListener(OnObjectInteracted);
    }

    protected virtual void OnObjectInteracted(){
    }
}
