using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

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
        gameObjectToReturnTo.GetComponent<CanvasGroup>().DOFade(1.0f, 0.2f).SetDelay(1.8f);
        //thisGameObject.SetActive(false);
        Tween fadeout = thisGameObject.GetComponent<CanvasGroup>().DOFade(0.0f, 0.2f).SetDelay(0.15f);
        StartCoroutine(WaitForCanvasToFadeOut(fadeout));
    }

    IEnumerator WaitForCanvasToFadeOut(Tween tween)
    {
        yield return new DOTweenCYInstruction.WaitForCompletion(tween);
        thisGameObject.SetActive(false);
    }
}
