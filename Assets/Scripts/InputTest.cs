using System;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputTest : MonoBehaviour
{
    public InputActionProperty GripAction;
    public InputActionProperty GripActionValue;
    public InputActionProperty TriggerAction;
    public InputActionProperty TriggerActionValue;
    public bool GripButton;
    public float GripValue;
    public bool TriggerButton;
    public float TriggerValue;
    void Update()
    {
        GripButton = GripAction.action.IsPressed();
        GripValue = GripActionValue.action.ReadValue<float>();
        TriggerButton = TriggerAction.action.IsPressed();
        TriggerValue = TriggerActionValue.action.ReadValue<float>();
    }
}
