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
            Debug.Log("�� �ε�");

            Destroy(gameObject);

            //catMario�� ü����, ����ī�޶��� target�ٲ��� 
            SwitchPlayer switchPlayer = GetComponent<SwitchPlayer>();
            switchPlayer.SwitchToCat();


            Follow follow = GetComponent<Follow>();
            GameObject targetObject = GameObject.FindGameObjectWithTag(follow.targetTag);
            follow.target = targetObject.transform;
            Debug.Log("Ÿ�ٹٲ�");


        }
    }
}
