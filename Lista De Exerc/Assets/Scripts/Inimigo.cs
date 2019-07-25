using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Inimigo : MonoBehaviour
{
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected Vector2 direction;
    [SerializeField]
    protected Transform target;
    [SerializeField]
    protected float _tipo;
    [SerializeField]
    protected bool passWall = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().name == "Exercicio1")
        
    }

    public void Init()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        direction = target.position - transform.position;
        direction = direction.normalized;
    }

    public virtual void Move()
    {
        Vector2 velocity = speed * direction * Time.deltaTime;
        transform.Translate(velocity);

    }

     
}
