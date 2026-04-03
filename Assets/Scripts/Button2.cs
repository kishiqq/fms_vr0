using UnityEngine;

public class Button2 : MonoBehaviour
{
    public Transform Player;
    public Transform TpPoint;
    public void OnPress()
    {
       Player.position = TpPoint.position;
    }
}
