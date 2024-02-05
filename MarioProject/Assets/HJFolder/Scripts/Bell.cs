using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bell : MonoBehaviour
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
            Debug.Log("∫ß ∫Œµ˙");

            Destroy(gameObject);

            //catMario∑Œ √º¿Œ¡ˆ, ∏ﬁ¿Œƒ´∏ﬁ∂Û¿« targetπŸ≤„¡‹ 
            SwitchPlayer switchPlayer = GetComponent<SwitchPlayer>();
            switchPlayer.SwitchToCat();


            Follow follow = GetComponent<Follow>();
            GameObject targetObject = GameObject.FindGameObjectWithTag(follow.targetTag);
            follow.target = targetObject.transform;
            Debug.Log("≈∏∞ŸπŸ≤ﬁ");


        }
    }
}
