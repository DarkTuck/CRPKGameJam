using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Table : InteractiveObject
{
    [SerializeField] GameObject gameObjectToLoad;
    [SerializeField] GameObject thisGameObject;
    protected override void OnObjectInteracted()
    {
        base.OnObjectInteracted();
        gameObjectToLoad.SetActive(true);
        thisGameObject.SetActive(false);

    }
}

