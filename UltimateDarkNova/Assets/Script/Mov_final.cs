using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_final : MonoBehaviour
{

    public GameObject disparoPrefab;
    public GameObject explosion;
    public Transform player;
    public float speed;

    int damage;
    // Start is called before the first frame update
    void Start()
    {
        damage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);

        if(this.transform.position.y == 4)
        {
            Vector3 newPosition = new Vector3(transform.position.x, 4f, transform.position.z);
            transform.position = newPosition;
        }
    }
}
