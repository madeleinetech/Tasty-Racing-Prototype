using UnityEngine;

public class WASDmove : MonoBehaviour
{
    public float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -2);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, 2);
        }
        //float xAxis = Input.GetAxisRaw("Horizontal");
        //float yAxis = Input.GetAxisRaw("Vertical");
        //Vector3 moveDirection = new Vector3(xAxis, 0.0f, yAxis);
        //Vector3 rotateVector = new Vector3(0, xAxis, 0);
        //transform.Rotate(rotateVector);
        //transform.position += moveDirection * speed;
        //transform.Translate(translation: transform.forward * yAxis * speed);

    }
}
