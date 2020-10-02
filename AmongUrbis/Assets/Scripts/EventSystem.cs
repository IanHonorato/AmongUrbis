using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public Transform cameraTask;
    public Transform task;
    private Vector3 origem = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        origem = cameraTask.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        cameraTask.position = task.position + new Vector3(0, 5.0f, 0);
    }

    public void taskCompleted() {
        cameraTask.position = origem;
        //falta gamemanager para colocar a task como concluida
    }
}
