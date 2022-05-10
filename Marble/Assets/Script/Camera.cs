using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    Vector3 offset;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindObjectOfType<PlayerController>().GetComponent<Transform>();
    }

    // Update is called once per frame
    //void LateUpdate()
    //{
    //    //transform.position = playerTransform.position - new Vector3(0, -1.5f, 2.5f);
    //    transform.position = Vector3.Lerp(transform.position, playerTransform.position - new Vector3(0, -1.5f, 2.5f), 0.1f);
    //    //transform.position = Vector3.Lerp(Vector3.up, Vector3.forward, .5f);
    //}
    private void FixedUpdate()
    {
        
        transform.position = Vector3.Lerp(transform.position, playerTransform.position - offset, 0.08f);
    }
}
