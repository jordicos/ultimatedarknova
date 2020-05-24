using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public float speed = 50.0f;
    private Rigidbody2D rb;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > 5.37)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "navelvl1" || other.gameObject.tag == "navelvl2")
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Destroy(e.gameObject, 0.15f);
        }
    }
}
