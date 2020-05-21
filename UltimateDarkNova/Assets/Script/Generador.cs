using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject navelvl1;

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
            Instantiate(navelvl1, transform.position = new Vector2(0.0f, 8.0f), transform.rotation = Quaternion.Euler(180, 0, 0));

            sactuales = seconds;
        }
    }
}
