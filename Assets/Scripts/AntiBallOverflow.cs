using UnityEngine;

public class AntiBallOverflow : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.IsChildOf(transform)){
            Destroy(other.gameObject);
        }
    }
}
