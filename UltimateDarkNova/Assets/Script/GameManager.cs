using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    float sactuales;
    float seconds = 10;

    bool levelEnd = false;

    public GameObject levelCompletado;

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
            nextLevel();
        }
    }

    public void nextLevel()
    {
        if (levelEnd == false)
        {
            levelEnd = true;
            levelComplete();
        }
    }

    private void levelComplete()
    {
        float activo = 5;
        activo -= Time.deltaTime;
        levelCompletado.SetActive(true);

        if (activo == 0.0f)
        {
            levelCompletado.SetActive(false);

        }
    }
}
