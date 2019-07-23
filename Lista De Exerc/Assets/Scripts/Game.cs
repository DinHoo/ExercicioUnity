using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField]
    GameObject[] listaPrefabInimigos = new GameObject[4];

    // lista com posições para spawnar os inimigos
    public List<Transform> spawnPointInimigos = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Exercicio1")
            StartExe1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartExe1()
    {
        if (GameObject.FindGameObjectWithTag("InimigoSpawn"))
        {
            print("achou");
            foreach (Transform filho in GameObject.FindGameObjectWithTag("InimigoSpawn").transform)
            {
                spawnPointInimigos.Add(filho);
            }
                       
        }

        spawnInimigo(listaPrefabInimigos[Random.Range(0, listaPrefabInimigos.Length)]);
    }

    //função para spawnar inimigos em determinada posição
    private void spawnInimigo(GameObject prefab)
    {
        if (!spawnPointInimigos.Any()) return;

        Vector3 position = spawnPointInimigos[Random.Range(0, spawnPointInimigos.Count)].position;

        Instantiate(prefab, position, Quaternion.identity);
    }
}
