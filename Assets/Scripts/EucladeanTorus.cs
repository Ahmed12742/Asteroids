
using UnityEngine;

public class EucladeanTorus : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        // Teleport the game object
        if (transform.position.x > 20)
        {

            transform.position = new Vector3(-20, transform.position.y, 0);

        }
        else if (transform.position.x < -20)
        {
            transform.position = new Vector3(20, transform.position.y, 0);
        }

        else if (transform.position.y > 20)
        {
            transform.position = new Vector3(transform.position.x, -20, 0);
        }

        else if (transform.position.y < -20)
        {
            transform.position = new Vector3(transform.position.x, 20, 0);
        }
    }
}

