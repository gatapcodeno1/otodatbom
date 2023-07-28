using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    protected List<GameObject> enemies;
    protected int MaxEnemy = 1;
    protected GameObject enemyPrefab;
    protected GameObject enemySpawnPos;
    protected float timer = 0;
    protected float delay = 0.1f;
     
    private void Awake()
    {
        enemyPrefab = GameObject.Find("EnemyPrefab");
        enemySpawnPos = GameObject.Find("EnemySpawnPos");
        enemyPrefab.SetActive(false);
        this.enemies = new List<GameObject>();
    }

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {

        if (PlayerCtrl.instance.damageRecive.IsDead())
        {
            return;
        }

        if(this.enemies.Count >= this.MaxEnemy)
        {
            return;
        }



        this.timer += Time.deltaTime;
        if(this.timer >= delay)
        {
            this.timer = 0;
            GameObject enemy = Instantiate(this.enemyPrefab);    
            enemy.transform.position = this.enemySpawnPos.transform.position;
            enemy.SetActive(true);
            enemy.transform.parent = transform;
            this.enemies.Add(enemy);

        }
        
       
    }
    void CheckDead()
    {
        GameObject enemy;
        for (int i = 0; i < enemies.Count; i++)
        {
            enemy = enemies[i];
            if (enemy == null)
            {
                this.enemies.RemoveAt(i);
            }
        }
    }
}
