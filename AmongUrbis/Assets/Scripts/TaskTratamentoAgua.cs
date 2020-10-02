using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using UnityEngine;

public class TaskTratamentoAgua : EventSystem
{
    public List<GameObject> dejetos;
    void Update()
    {
        for (int i = 0; i <= dejetos.Count-1; i++)
        {
            if (dejetos[i] == null)
                dejetos.RemoveAt(i);
            
            if (dejetos.Count == 0)
            {
                //task concluida
                taskCompleted();
            }
        }
    }

}
