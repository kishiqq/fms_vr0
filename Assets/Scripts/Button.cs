using UnityEngine;

public class Button : MonoBehaviour
{
    public Transform Player;
    public GameObject[] Objects;
    public void OnPress()
    {
        Instantiate(Objects[Random.Range(0, Objects.Length)], Player.position + Vector3.up * 6, Quaternion.identity);
    }
}
