using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_naveFinal : MonoBehaviour
{

    public GameObject nave;
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

        if (sactuales == 0.0f)
        {
            Instantiate(nave, transform.position = new Vector2(0, 8.0f), transform.rotation = Quaternion.Euler(180, 0, 0));
            //https://www.youtube.com/watch?v=006390y960g
        }
    }
}
