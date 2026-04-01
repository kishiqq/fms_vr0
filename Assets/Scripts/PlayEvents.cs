using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class PlayEvents : MonoBehaviour
{
    private ParticleSystem[] children;
    void Start()
    {
        TeleportationAnchor anchor = GetComponent<TeleportationAnchor>();
        children = new ParticleSystem[transform.childCount];
        for (int i = 0; i < transform.childCount; i++) { 
            Transform child = transform.GetChild(i);
            if (child.gameObject.GetComponent<ParticleSystem>() != null) {
                anchor.teleporting.AddListener((args) => {
                    children[i] = child.GetComponent<ParticleSystem>();
                    children[i].Stop();
                });
            }
        }
    }
    public void Play()
    {
        foreach (var child in children) { 
            child.Play();
        }
    }
}
