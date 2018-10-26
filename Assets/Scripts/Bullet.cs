
using UnityEngine;

public class Bullet  :  MonoBehaviour
{
    public float speed = 1f;

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}