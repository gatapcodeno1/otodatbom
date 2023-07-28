using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageRecive : MonoBehaviour
{

    protected int hp = 3;
    
    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }

    public virtual void Recive(int damage)
    {
        hp -= damage;

        if(IsDead() == true)
        {
            GameObject.Destroy(transform.gameObject);
        }

    }


    

}
