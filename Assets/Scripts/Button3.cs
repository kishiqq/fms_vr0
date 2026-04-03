using Unity.VisualScripting;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public bool Active;
    public void OnPress()
    {
        if (Active) { return; }
        gameObject.AddComponent<Rigidbody>();
        Active = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Active)
        {
            var a = Instantiate(gameObject);
            a.GetComponent<Button3>().Active = true;
            a.GetComponent<Rigidbody>().linearVelocity = GetComponent<Rigidbody>().linearVelocity;
            a.GetComponent<Rigidbody>().angularVelocity = GetComponent<Rigidbody>().angularVelocity;
        }
    }
}
