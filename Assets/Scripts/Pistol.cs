using UnityEngine;
public class Pistol : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePoint;
    public float Speed = 20f;
    public float Lifetime = 6f;
    public AudioClip Clip;
    private AudioSource Source;
    private void Start()
    {
        Source = GetComponent<AudioSource>();
        Source.clip = Clip;
    }
    public void FireBullet()
    {
        GameObject bullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        //rigidbody.AddRelativeForce(Vector3.forward * Speed, ForceMode.Impulse);
        rigidbody.linearVelocity = FirePoint.forward * Speed;
        Source.Play();
        Destroy(bullet, Lifetime);
    }
}
