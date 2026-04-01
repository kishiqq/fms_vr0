using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class AddEvents : MonoBehaviour
{
    void Start()
    {
        TeleportationAnchor anchor = GetComponent<TeleportationAnchor>();
        for (int i = 0; i < transform.childCount; i++) { 
            Transform child = transform.GetChild(i);
            if (child.gameObject.GetComponent<ParticleSystem>() != null) {
                anchor.teleporting.AddListener((args) => {
                    child.GetComponent<ParticleSystem>().Stop();
                    child.GetComponent<ParticleSystem>().Play();
                });
            }
        }
    }
}
