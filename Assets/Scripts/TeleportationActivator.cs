using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{
    public InputActionProperty TeleportActivatorAction;
    public XRRayInteractor TeleportInteractor;
    void Start()
    {
        TeleportInteractor.gameObject.SetActive(false);
        TeleportActivatorAction.action.performed += ActionPerformed;
    }
    void ActionPerformed(InputAction.CallbackContext callback)
    {
        TeleportInteractor.gameObject.SetActive(true);
    }
    void Update()
    {
        if (TeleportActivatorAction.action.WasReleasedThisFrame()) { 
            TeleportInteractor.gameObject.SetActive(false);
        }
    }
}
