using System.Xml.Serialization;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int FrameDelay = 20;
    public Transform BottomLeftCorner;
    public Transform UpRightCorner;
    private Vector3 blp, urp;
    private int i;
    private void Start()
    {
        blp=BottomLeftCorner.position;
        urp=UpRightCorner.position;
    }
    void Update()
    {
        i=(i+1)%FrameDelay;
        if (i == 0)
        {
            Instantiate(prefab, new Vector3(Random.Range(Mathf.Min(blp.x,urp.x), Mathf.Max(blp.x, urp.x)), Random.Range(Mathf.Min(blp.y, urp.y), Mathf.Max(blp.y, urp.y)), Random.Range(Mathf.Min(blp.z, urp.z), Mathf.Max(blp.z, urp.z)))/*SpawnPoint.position*/, new Quaternion(),transform);
        }
    }
}
