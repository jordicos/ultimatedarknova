using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_background : MonoBehaviour
{
    public GameObject background;

    float sactuales;
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        sactuales = seconds;
    }

    // Update is called once per frame
    void Update()
    {
        sactuales -= Time.deltaTime;

        if (sactuales <= 0.0f)
        {
            Instantiate(background, transform.position = new Vector2(0, 12.831f), transform.rotation = Quaternion.Euler(0, 0, 0));

            sactuales = seconds;
        }
    }
}
