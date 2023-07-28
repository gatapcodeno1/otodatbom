using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int m_playerLocation = 19;
        int m_spawnLocation = 20;
        if(m_playerLocation == m_spawnLocation)
        {
            Debug.Log("Spawn");
        }
        else
        {
            Debug.Log("notSpawn");
        }
    }

    // Update is called once per frame
    
}
