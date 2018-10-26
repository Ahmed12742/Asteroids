using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float rotationForce = 1f;
    public float speed = 1f;
    public GameObject bulletPrefab;
    public Text pointsLabel;
    public float shootTime;
    private float lastShootTime;
    public float playerDamage = 25f;
    public bool allowToShoot;
    
    private Rigidbody2D body;
    private Transform bulletPoint;
    private HealthScript health;

    private void Start()
    {
        health = GetComponent<HealthScript>();
        body = GetComponent<Rigidbody2D>();
        bulletPoint = transform.GetChild(0);
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Mathf.Clamp(Input.GetAxis("Vertical"), 0f, 1f);

        Vector3 actualSpeed = transform.up * vertical * speed;

        body.AddTorque(rotationForce * horizontal);

        allowToShoot = !Input.GetKey(KeyCode.LeftShift);
        if (!allowToShoot)
        {
            actualSpeed *= 2f;
        }
        body.AddForce(actualSpeed);
        //body.AddForce(transform.up * vertical * speed);

        if (allowToShoot && Input.GetButton("Fire1") && Time.time - lastShootTime >= shootTime)
        {
            Shoot();
            lastShootTime = Time.time;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Small Asteroid")
        {
            health.RemoveHealth(25f); 
        }
    }

    private void Shoot()
    {
        GameObject go = Instantiate(bulletPrefab);
        go.transform.position = bulletPoint.position;
        Rigidbody2D bulletBody = go.GetComponent<Rigidbody2D>();
        Bullet bullet = go.GetComponent<Bullet>();

        Vector2 velocity = transform.up * bullet.speed;
        bulletBody.AddForce(velocity, ForceMode2D.Impulse);
    }
}

    


