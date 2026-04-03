using UnityEngine;
[RequireComponent (typeof(Pistol))]
public class Autoweapon : MonoBehaviour
{
    public float FireSpeed = 0.2f;
    public bool IsFire = false;
    private Pistol pistol;
    private float time;
    void Start()
    {
        pistol = GetComponent<Pistol>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (IsFire && time > FireSpeed ) { 
            pistol.FireBullet();
            time = 0;
        }
    }
    public void FireOn()
    {
        IsFire = true;
    }
    public void FireOff() {
        IsFire = false;
    }
}
