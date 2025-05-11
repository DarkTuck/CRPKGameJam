using UnityEngine;
using UnityEngine.UI;

public class ReturnToPreviousRoom : InteractiveObject
{
    [SerializeField] private GameObject buttonsToReturnBack;
    [SerializeField] private GameObject thisGameObject;
    [SerializeField] private GameObject gameObjectToReturnTo;

    protected override void Start()
    {
        foreach(Button button in buttonsToReturnBack.GetComponentsInChildren<Button>()){
            button.onClick.AddListener(OnObjectInteracted);
        }
    }
    protected override void OnObjectInteracted(){
        base.OnObjectInteracted();
        gameObjectToReturnTo.SetActive(true);
        thisGameObject.SetActive(false);
    }
}
