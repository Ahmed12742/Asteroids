using UnityEngine;

public class Powerups : MonoBehaviour
{

    //Shotgun Powerup
    var bulletPrefab:Transform;
var strayFactor : int;

function Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            var randomNumberX = Random.Range(-strayFactor, strayFactor);
            var randomNumberY = Random.Range(-strayFactor, strayFactor);
            var randomNumberZ = Random.Range(-strayFactor, strayFactor);
            var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.Rotate(randomNumberX, randomNumberY, randomNumberZ);
            bullet.rigidbody.AddForce(bullet.transform.forward * 10000);
        }


    }
