using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("TEST");
            Invoke("DestroyCollectibles", 2f);
        }
    }
    void DestroyCollectibles()
    {
        Destroy(this.gameObject);
    }
}
