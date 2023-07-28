using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public virtual void Despawn()
    {
        Destroy(gameObject);
    }
}
