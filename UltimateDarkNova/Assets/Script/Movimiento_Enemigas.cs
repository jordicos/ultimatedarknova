using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Enemigas : MonoBehaviour
{
    public GameObject disparoPrefab;
    public Transform player;
    public float seconds;
    private float sactuales;
    public float speed;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        sactuales = seconds;
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
}
