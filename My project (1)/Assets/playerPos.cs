using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerPos : MonoBehaviour
{
 
    List<GameObject> minion;
    public GameObject minionPrefab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    private void Start()
    {
        this.minion = new List<GameObject>();
        
    }

    void Update()
    {

        

        
        this.Spawn();
        CheckMinionDead();

    }
    void CheckMinionDead()
    {
        GameObject minion1;
        for(int i = 0; i < this.minion.Count; i++) {
            minion1 = this.minion[i];
            if (minion1 == null) minion.RemoveAt(i);
        }
    }

    void Spawn()
    {

        this.spawnTimer += Time.deltaTime;
        if(this.spawnTimer < spawnDelay)
        {
            return;
        }
        this.spawnTimer = 0f;

        if(this.minion.Count  >= 7)
        {
            return;
        }
        int index = this.minion.Count + 1;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Bomb" + index;
       minion.SetActive(true);
        minion.transform.position = transform.position;
        
        this.minion.Add(minion);

    }
    
}
