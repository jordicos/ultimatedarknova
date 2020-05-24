using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Generador : MonoBehaviour
{
    public GameObject navelvl1;
    float sactuales;
    public float seconds;

    int total = 50;

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
            Instantiate(navelvl1, transform.position = new Vector2(RandomNumber(-6, 6), 8.0f), transform.rotation = Quaternion.Euler(180, 0, 0));

            sactuales = seconds;
        }
    }
    public int RandomNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }
}
