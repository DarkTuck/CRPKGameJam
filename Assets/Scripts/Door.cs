using UnityEngine;

public class Door :InteractiveObject
{
    protected override void OnObjectInteracted()
    {
        base.OnObjectInteracted();
        Debug.Log("AAAAAAAAAAAA");
    }
}
