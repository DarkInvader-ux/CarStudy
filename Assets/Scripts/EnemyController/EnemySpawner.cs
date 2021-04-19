using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject[] ObjectPool;
    public GameObject EnemyPrefab;
    public int size;
    private Vector3 RandomPos;
    private float Delay;
    [SerializeField]private float SpawnDelay;
    //public GameObject[] Enemies;
    // create a list or array that stores the number of enemies in the scene if that number hits zero spanw enemies
    // Start is called before the first frame update
    void Start()
    {
        ObjectPool = new GameObject[size];
        for(int i = 0;i < size; i ++)
        {
            ObjectPool[i] = Instantiate(EnemyPrefab);
            ObjectPool[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Delay > 0)
        {
            Delay -= Time.deltaTime;
        }
        else
        {
            Delay = SpawnDelay;
            Spawn();
        }
        
        

    }
    private void Spawn()
    {
        for(int i = 0; i < size; i++)
        {
            if(!ObjectPool[i].activeInHierarchy)
            {
                RandomPos = new Vector3(Random.Range(-20, 55), 0, Random.Range(150, 400));
                ObjectPool[i].transform.position = RandomPos;
                //ObjectPool[i].transform.rotation = transform.rotation;
                ObjectPool[i].SetActive(true);
                return;
            }
        }
    }
}
