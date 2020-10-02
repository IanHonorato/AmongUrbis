using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskReciclagem : EventSystem
{
    public List<GameObject> lixos;
    private List<Vector3> posicaoOrigem = new List<Vector3>();

    void Update()
    {
        taskFinished();
    }

    public void resetTask() {
        SceneManager.LoadScene("AmongUrbis");
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
        player.transform.position = new Vector3(44.02f, 4.65f, 42.79f);
    }

}
