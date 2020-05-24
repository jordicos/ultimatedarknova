using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_controller : MonoBehaviour
{

    private GameObject health;
    public GameObject disparoPrefab;
    public GameObject explosion;
    public GameObject gameOver;

    public Transform player;
    public float force;

    private int vidas;

    


    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("vida");

        gameOver.SetActive(false);

        vidas = 3;
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity= new Vector2(move * Time.deltaTime * force, 0.0f);
        if (Input.GetKeyDown("space"))
        {
            disparar();
        }
    }
    public void disparar()
    {
        GameObject b = Instantiate(disparoPrefab) as GameObject;
        b.transform.position = player.transform.position;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        GameObject e = Instantiate(explosion) as GameObject;

        if(other.gameObject.tag == "disparo_naveE" || other.gameObject.tag == "navelvl1" || other.gameObject.tag == "navelvl2")
        {
            vidas--;
            Debug.Log("Ahora hay " + vidas + " vidas");
            health.SendMessage("Damage", 1);
            Destroy(other.gameObject);
            if (vidas == 0)
            {
                e.transform.position = this.transform.position;
                
                Destroy(this.gameObject);
                Destroy(e.gameObject, 0.15f);
                gameOver.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
