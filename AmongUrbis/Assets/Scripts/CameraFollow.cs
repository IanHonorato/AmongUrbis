using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float damptime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = GetComponent<Camera>().WorldToScreenPoint(player.position);
        Vector3 delta = player.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
        Vector3 destination = transform.position + delta;
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, damptime);
        //transform.position = Vector3.Lerp(transform.position, player.position, t);
    }
}
