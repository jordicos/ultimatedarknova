using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class Generador : MonoBehaviour
{
    public GameObject navelvl1;
    float sactuales;
    public float seconds;

    float tiempoTotal;

    public GameObject levelCompletado;

    int total = 10;

    // Start is called before the first frame update
    void Start()
    {
        sactuales = seconds;
        //tiempoTotal = 10;
        levelCompletado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        sactuales -= Time.deltaTime;
        //tiempoTotal -= Time.deltaTime;

        if (sactuales <= 0.0f)
        {
            Instantiate(navelvl1, transform.position = new Vector2(RandomNumber(-6, 6), 8.0f), transform.rotation = Quaternion.Euler(180, 0, 0));

            sactuales = seconds;

            total--;
            if(total == 0)
            {
                Nivel1Acabado();
                RemoveAfterSeconds(3);
            }
        }
    }
    public int RandomNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }

    private void Nivel1Acabado()
    {
        levelCompletado.SetActive(true);
        Time.timeScale = 0;
        SceneManager.LoadScene(1);
    }

    IEnumerator RemoveAfterSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        levelCompletado.SetActive(false);
    }
}
