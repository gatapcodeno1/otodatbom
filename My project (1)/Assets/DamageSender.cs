using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{

    protected EnemyController enemyController;

    private void Awake()
    {
        this.enemyController = GetComponent<EnemyController>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        DamageRecive damageRecive = collision.GetComponent<DamageRecive>();
        if(collision.name != "anhHanh")
        {
            GameObject.Destroy(this.gameObject);
            damageRecive.Recive(1);
            /*this.enemyController.despawner.Despawn();*/
        }
        
        
        
    }
}
