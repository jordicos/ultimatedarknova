using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Enemigas : MonoBehaviour
{
    public GameObject disparoPrefab;
    public GameObject explosion;
    public Transform player;
    public float seconds;
    private float sactuales;
    public float speed;
    private Vector2 screenBounds;

    private int damagelvl2;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        sactuales = seconds;
        damagelvl2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        if (transform.position.y < -5.51f)
        {
            Destroy(this.gameObject);
        }

        sactuales -= Time.deltaTime;
        if (sactuales <= 0.0f)
        {
            disparar();
            sactuales = seconds;
        }
    }
    public void disparar()
    {
        GameObject b = Instantiate(disparoPrefab) as GameObject;
        b.transform.position = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "naveP")
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(this.gameObject);
            Destroy(e.gameObject, 0.15f);
        } else if(other.gameObject.tag == "disparo_naveP" && this.gameObject.tag == "navelvl2")
        {
            Destroy(other.gameObject);
            damagelvl2++;
            Score.scoreAmount += 100;
            if(damagelvl2 == 2)
            {
                GameObject e = Instantiate(explosion) as GameObject;
                e.transform.position = transform.position;
                
                Destroy(this.gameObject);
                Destroy(e.gameObject, 0.15f);
                Score.scoreAmount += 100;
            }
        }
    }
}
