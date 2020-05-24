using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Image health3;
    public Image health2;
    public Image health1;

    float vida;
    float maxVida = 3f;

    // Start is called before the first frame update
    void Start()
    {
        vida = maxVida;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int cant)
    {
        vida = Mathf.Clamp(vida - cant, 0, maxVida);
        switch (maxVida - vida)
        {
            case 1:
                Destroy(health1);
                break;
            case 2:
                Destroy(health2);
                break;
            case 3:
                Destroy(health3);
                break;
        }
    }
}
