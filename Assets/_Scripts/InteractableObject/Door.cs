using System.Collections;
using DG.Tweening;
using UnityEngine;


public class Door : InteractiveObject
{
    [SerializeField] GameObject gameObjectToLoad;
    [SerializeField] GameObject thisGameObject;
    protected override void OnObjectInteracted()
    {
        base.OnObjectInteracted();
        gameObjectToLoad.SetActive(true);
        gameObjectToLoad.GetComponent<CanvasGroup>().DOFade(1.0f, 0.2f).SetDelay(1.8f);
        Tween fadeout = thisGameObject.GetComponent<CanvasGroup>().DOFade(0.0f, 0.2f).SetDelay(0.15f);
        StartCoroutine(WaitForCanvasToFadeOut(fadeout));
    }
    IEnumerator WaitForCanvasToFadeOut(Tween tween)
    {
        yield return new DOTweenCYInstruction.WaitForCompletion(tween);
        thisGameObject.SetActive(false);
    }
}
