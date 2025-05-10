using UnityEngine;
using UnityEngine.UI;
public class InteractiveObject : MonoBehaviour
{
    [SerializeField] protected Button objectArea;
    protected virtual void Start()
    {
        objectArea.onClick.AddListener(OnObjectInteracted);
    }

    protected virtual void OnObjectInteracted(){
    }
}
