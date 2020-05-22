﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_controller : MonoBehaviour
{
    public GameObject disparoPrefab;
    public Transform player;
    public float force;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity= new Vector2(move * Time.deltaTime * force, 0.0f);
        if (Input.GetKeyDown("space"))
        {
            disparar();
        }
    }
    public void disparar()
    {
        GameObject b = Instantiate(disparoPrefab) as GameObject;
        b.transform.position = player.transform.position;
    }
}
