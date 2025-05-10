using UnityEngine;


public class Door :InteractiveObject
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
