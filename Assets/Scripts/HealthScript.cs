
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public float health = 100f;
 
    public void RemoveHealth(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }


}
