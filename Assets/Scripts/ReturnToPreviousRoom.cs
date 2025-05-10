using UnityEngine;
using UnityEngine.UI;

public class ReturnToPreviousRoom : MonoBehaviour
{
    [SerializeField] private GameObject buttonsToReturnBack;
    [SerializeField] private GameObject thisGameObject;
    [SerializeField] private GameObject gameObjectToReturnTo;

    private void Start()
    {
        foreach(Button button in buttonsToReturnBack.GetComponentsInChildren<Button>()){
            button.onClick.AddListener(OnButtonClicked);
        }
    }

    private void OnButtonClicked(){
        gameObjectToReturnTo.SetActive(true);
        thisGameObject.SetActive(false);
    }
}
