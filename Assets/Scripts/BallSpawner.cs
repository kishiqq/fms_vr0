using System.Xml.Serialization;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int FrameDelay = 20;
    public Transform SpawnPoint;
    private int i;

    // Update is called once per frame
    void Update()
    {
        i=(i+1)%FrameDelay;
        if (i == 0)
        {
            Instantiate(prefab, SpawnPoint.position, new Quaternion(),transform);
        }
    }
}
