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

    private int nextLevel;

    public GameObject levelCompletado;

    int total = 10;

    // Start is called before the first frame update
    void Start()
    {
        sactuales = seconds;
        //tiempoTotal = 10;
        levelCompletado.SetActive(false);

        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
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
                NivelAcabado();
                RemoveAfterSeconds(3);
            }
        }
    }
    public int RandomNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }

    public void NivelAcabado()
    {
        levelCompletado.SetActive(true);
        Time.timeScale = 0;
        SceneManager.LoadScene(nextLevel);
    }

    IEnumerator RemoveAfterSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        levelCompletado.SetActive(false);
    }
}
