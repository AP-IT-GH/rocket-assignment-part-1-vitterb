using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField] Vector3 offset;

    [SerializeField] float smoothing = 10f;

    Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    Vector3 targetPos = Vector3.zero;
    private void FixedUpdate()
    {

        if(playerTransform != null)
            targetPos = playerTransform.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * smoothing);

        transform.LookAt(playerTransform);
    }
}
