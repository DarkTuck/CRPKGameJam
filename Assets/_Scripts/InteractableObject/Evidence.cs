using System;
using UnityEngine;

public class Evidence : InteractiveObject
{
    [SerializeField] EvidenceObject evidenceObject;
    [SerializeField] StringEvent uIText;
    [SerializeField] string messege = "Znalazłeś:";
    protected override void OnObjectInteracted()
    {
        base.OnObjectInteracted();
        evidenceObject.status = EvidenceStatus.UnExplored;
        uIText.TextValue = $@"{messege} {evidenceObject.name}";
    }
}
