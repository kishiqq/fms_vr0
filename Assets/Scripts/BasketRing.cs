using UnityEngine;

public class BasketRing : MonoBehaviour
{
    public ParticleSystem effect;
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            if (effect != null)
            {
                effect.Play();
            }
        }
    }
}
