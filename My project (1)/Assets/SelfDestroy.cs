using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        if(Vector3.Distance(this.transform.position , PlayerCtrl.instance.transform.position) > 20f)
        {
            Destroy(this.gameObject);
        }
    }



    // Update is called once per frame
    void Destroy()
    {
        Destroy(gameObject);
    }
}
