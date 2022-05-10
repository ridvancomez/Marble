using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public bool PuanArtir { get; set; }
    public bool Dustum { get; private set; }
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizonral = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(horizonral, 0, vertical));

        if(transform.position.y < -4)
        {
            Dustum = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Altin")
        {
            Destroy(other.gameObject);
            PuanArtir = true;
        }
    }
}
