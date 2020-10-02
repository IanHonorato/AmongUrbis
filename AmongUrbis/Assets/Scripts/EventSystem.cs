using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public Transform player;
    public Transform task;
    private void OnMouseDown()
    {
        player.transform.position = task.transform.position;
        Destroy(gameObject);
    }
}
