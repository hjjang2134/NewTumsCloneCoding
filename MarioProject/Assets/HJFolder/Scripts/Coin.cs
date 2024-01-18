using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Mario")
        {
            Debug.Log("何碟");

            Destroy(gameObject);
            //内牢剧1 疵府绰 内靛 累己秦具凳 
        }
    }
}
