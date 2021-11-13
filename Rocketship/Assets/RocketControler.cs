using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControler : MonoBehaviour
{

    // source Zarriix (youtube.com/channel/UC8qH1R71ZxBdVI-nAZ6dBEg)

    [SerializeField] float thrusterForce = 10f;
    [SerializeField] float TitltingForce = 10f;

    Rigidbody rb;

    bool thrust = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W);

        if (!Mathf.Approximately(tilt,0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f, 0f, TitltingForce * tilt * Time.deltaTime)));
        }

        rb.freezeRotation = false;
    }

    private void FixedUpdate()
    {
        if (thrust)
        {
            rb.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
        }
    }
}
