using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    Rigidbody2D body;
    [SerializeField]
    float speed;

    float horizontal;
    float vertical;


    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (SceneManager.GetActiveScene().name == "Exercicio1")
        body.velocity = new Vector3(horizontal * speed, 0.0f, 0.0f);
        else
        body.velocity = new Vector3(horizontal * speed, vertical * speed, 0.0f);

    }
}
