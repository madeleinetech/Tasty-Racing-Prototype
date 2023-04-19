using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarController : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveInput;
    public float fwdSpeed;


    public Rigidbody sphereRB;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical");
        moveInput *= fwdSpeed;
        transform.position = sphereRB.transform.position;
    }

    private void FixedUpdate(){
        sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
    }
}
