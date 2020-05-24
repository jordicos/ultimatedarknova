using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_navesE : MonoBehaviour
{
    public float speed = 50.0f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {  
        if (transform.position.y < -5.57)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "disparo_naveP")
        {
            Debug.Log("alcanzado");
        } 
    }
}
