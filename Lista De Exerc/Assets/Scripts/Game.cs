using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField]
    GameObject[] listaPrefabInimigos = new GameObject[4];

    float timerStart;
    int score = 0;
    public TextMeshProUGUI scoreText;

    [SerializeField]
    float timerMaxScore;

    float timerStartInimigo;
    [SerializeField]
    float timerMaxInimigo;

    
    float timerStartDificuldade;
    [SerializeField]
    float timerMaxDificuldade;

    [SerializeField]
    [Range(0.1f, 1.0f)]
    float spawnIncrease;

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
        if (SceneManager.GetActiveScene().name == "Exercicio1")
            UpdateExe1();
    }

    ////////////////////////////////////////////////////////////////////////////////////////
    /// Exercicio 1
    ///////////////////////////////////////////////////////////////////////////////////////
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
        //spawnInimigo(listaPrefabInimigos[Random.Range(0, listaPrefabInimigos.Length)]);
        timerStart = Time.time;
        timerStartInimigo = Time.time;
        timerStartDificuldade = Time.time;
        scoreText.text = "Score: " + score;
    }

    void UpdateExe1()
    {
        if (Time.time >= timerStartDificuldade + timerMaxDificuldade)
        {
            timerStartDificuldade = Time.time;
            timerMaxInimigo *= spawnIncrease;
        }
        if (Time.time >= timerStartInimigo + timerMaxInimigo)
        {
            timerStartInimigo = Time.time;
            spawnInimigo(listaPrefabInimigos[Random.Range(0, listaPrefabInimigos.Length)]);
        }
        if (Time.time >= timerStart + timerMaxScore)
        {
            timerStart = Time.time;
            score += 5;

            scoreText.text = "Score: " + score;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////
    //função para spawnar inimigos em determinada posição
    private void spawnInimigo(GameObject prefab)
    {
        if (!spawnPointInimigos.Any()) return;

        Vector3 position = spawnPointInimigos[Random.Range(0, spawnPointInimigos.Count)].position;

        Instantiate(prefab, position, Quaternion.identity);
    }
}
