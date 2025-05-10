using System;
using UnityEngine;

[CreateAssetMenu(fileName = "StringEvent", menuName = "Scriptable Objects/StringEvent")]
public class StringEvent : ScriptableObject
{
    private String textValue;
    public delegate void ValueChangedDelegate(bool isDebug);
    ValueChangedDelegate valueChangedDelegate;
    [SerializeField] private bool debugChange;

    public String TextValue
    {
        set
        {
            textValue = value;
            ValueChanged();
        }
        get
        {
            return textValue;
        }
    }

    private void ValueChanged()
    {
        if (valueChangedDelegate != null)
        {
            valueChangedDelegate(debugChange);
        }
    }
    public void RegisterDelegate(ValueChangedDelegate givenDelegate)
    {
        valueChangedDelegate += givenDelegate;
    }

    public void UnregisterDelegate(ValueChangedDelegate givenDelegate)
    {
        valueChangedDelegate -= givenDelegate;
    }
}
