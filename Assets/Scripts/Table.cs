using UnityEngine;

public class Table : InteractiveObject
{
    protected override void OnObjectInteracted()
    {
        base.OnObjectInteracted();
        Debug.Log("AAAAA");
    }
}
