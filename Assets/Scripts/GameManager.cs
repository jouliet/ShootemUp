using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemyPreFab;
    [SerializeField] UIManager uIManager;
    private float spawnInterval = 3;

    private void Awake() {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 2, spawnInterval);
    }

    private void Update() {
        
    }

    public void SpawnEnemy() {
        float height = Random.Range(-4, 4);
        Instantiate(enemyPreFab, Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, 0)) + new Vector3(0, height, 0), Quaternion.identity);
    }
}
