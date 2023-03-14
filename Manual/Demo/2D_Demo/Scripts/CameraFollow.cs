using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 vel = Vector3.zero;

    public float smoothSpeed = .125f;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        Vector3 desiredPos =  new Vector3 (player.transform.position.x,player.transform.position.y, -10f);
        Vector3 smoothedPos = Vector3.SmoothDamp(transform.position, desiredPos, ref vel, smoothSpeed);
        transform.position = smoothedPos;
    }
}
