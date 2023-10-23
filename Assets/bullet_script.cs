using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public int distance = 40;
    public Rigidbody2D rb;
    public int damage;
    public GameObject Enemy_death;
    void Start()
    {
        rb.velocity = transform.up * speed;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > distance) {
            Destroy(gameObject);
        }
        
    }
    
    void OnTriggerEnter2D(Collider2D hitInfo) {
        enemy enmy = hitInfo.GetComponent<enemy>();
        if (enmy != null) {
            enmy.TakeDamage(damage);
        }
        Instantiate(Enemy_death, transform.position, Quaternion.identity);
        
        Debug.Log("hit");
        Destroy(gameObject);
    }
}
