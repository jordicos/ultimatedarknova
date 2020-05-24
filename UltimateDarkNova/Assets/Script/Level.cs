using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{

    public int levelNum;
    private Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "LEVEL: " + levelNum;
    }
}
