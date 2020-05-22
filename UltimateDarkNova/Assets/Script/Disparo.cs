using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public float speed = 50.0f;
    private Rigidbody2D rb;
    public GameObject explosion;

    float sactuales;
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);

        sactuales = seconds;
    }

    // Update is called once per frame
    void Update()
    {
        sactuales -= Time.deltaTime;

        if(sactuales <= 0.0f)
        {
            sactuales = seconds;
        }

        if (transform.position.y > 5.37)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "navelvl1")
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Destroy(e.gameObject, 0.15f);
            
        }
    }
}
