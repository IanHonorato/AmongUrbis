using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskReciclagem : EventSystem
{
    public List<GameObject> lixos;
    private List<Vector3> posicaoOrigem = new List<Vector3>();
    private Vector3 origem = Vector3.zero;
    private int auxiliar = 0;
    void Start()
    {
        Debug.Log("iniciei");
        origem = cameraTask.position;
        for (int i = 0; i < lixos.Count; i++)
        {
            posicaoOrigem[i] = lixos[i].transform.position;
            auxiliar++;
        }
    }

    void Update()
    {
        taskFinished();
    }

    public void resetTask() {
        for (int i = 0; i < auxiliar; i++) {
            Debug.Log("resettask");
            lixos[i].transform.position = posicaoOrigem[i];
        }
    }

    public void taskFinished() {
        for (int i = 0; i < lixos.Count; i++) {
            if (lixos[i] == null)
                lixos.RemoveAt(i);

            if (lixos.Count == 0)
                taskReciclagemCompleted();
        }
    }

    public void taskReciclagemCompleted() {
        cameraTask.position = origem;
    }

}
