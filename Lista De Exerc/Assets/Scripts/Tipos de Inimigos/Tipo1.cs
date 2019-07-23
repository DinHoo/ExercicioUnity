using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tipo1 : Inimigo
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
}
