using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_final : MonoBehaviour
{

    public GameObject disparoPrefab;
    public GameObject explosion;
    public GameObject levelCompletado;
    public float seconds;
    private float sactuales;
    public float speed;

    int damage;
    // Start is called before the first frame update
    void Start()
    {
        damage = 0;
        sactuales = seconds;
        levelCompletado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);

        sactuales -= Time.deltaTime;
        if (sactuales <= 0.0f)
        {
            disparar();
            sactuales = seconds;
        }
    }

    public void disparar()
    {
        Instantiate(disparoPrefab, transform.position, transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "naveP")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Destroy(explosion.gameObject, 0.15f);
        }
        else if (other.gameObject.tag == "disparo_naveP")
        {
            Destroy(other.gameObject);
            damage++;
            Score.scoreAmount += 100;
            if (damage == 10)
            {

                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(this.gameObject);
                Destroy(explosion.gameObject, 0.15f);
                NivelAcabado();
                Score.scoreAmount += 1000;
            }
        }
    }

    public void NivelAcabado()
    {
        levelCompletado.SetActive(true);
        Time.timeScale = 0;
    }
}
