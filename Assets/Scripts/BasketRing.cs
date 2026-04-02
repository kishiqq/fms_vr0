using UnityEngine;

public class BasketRing : MonoBehaviour
{
    public ParticleSystem effect;
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            if (other.GetComponent<Rigidbody>() != null && other.GetComponent<Rigidbody>().linearVelocity.y < 0)
            {
                if (effect != null)
                {
                    effect.Play();
                    Instantiate(other, new Vector3(other.transform.position.x + Random.Range(-3, 3), other.transform.position.y - 2, other.transform.position.z + Random.Range(-3, 3)),other.transform.rotation,other.transform.parent);
                }
            }
        }
    }
}
