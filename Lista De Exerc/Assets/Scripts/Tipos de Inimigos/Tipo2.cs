using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tipo2 : Inimigo
{
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("collidiu");
        if (collision.CompareTag("Wall") && passWall)
        {
            passWall = false;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
