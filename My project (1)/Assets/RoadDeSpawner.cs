using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDeSpawner : MonoBehaviour
{
    protected float distance = 0;

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, transform.position);
        if (distance > 70)
        {
            this.DeSpawn();
        }
    }

    protected virtual void DeSpawn()
    {
        Destroy(gameObject);
    }

}
