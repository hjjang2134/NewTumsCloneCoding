using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public string targetTag = "Mario";
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);
        target = targetObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
