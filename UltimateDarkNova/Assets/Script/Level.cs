using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{

    public static int levelNum;
    private Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelText = GetComponent<Text>();
        levelNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "LEVEL: " + levelNum;
    }
}
