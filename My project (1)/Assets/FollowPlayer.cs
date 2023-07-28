using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    public int speedMaxEnemy = 30;
    // Start is called before the first frame update

    public float randomPosition;

    private void Awake()
    {
        randomPosition = Random.Range(-6,6);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            this.Follow();
        }
    }


    void Follow()
    {
        Vector3 pos = this.player.position;
        pos.x = randomPosition;

        Vector3 distance = pos - transform.position;
        if(distance.magnitude >= 4)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * 4;
            transform.position =
                Vector3.MoveTowards(transform.position, targetPoint, speedMaxEnemy * Time.fixedDeltaTime);
        }

    }

    

}


