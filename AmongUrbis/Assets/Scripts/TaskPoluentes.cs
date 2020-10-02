using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskPoluentes : EventSystem
{
    public List<ParticleSystem> particleSystems;

    void Update()
    {
        taskFinished();
    }

    public void taskPoluentesCompleted()
    {
        player.transform.position = new Vector3(44.02f, 4.65f, -41.39f);
    }

    public void taskFinished()
    {
        for (int i = 0; i < particleSystems.Count; i++)
        {
            if (particleSystems[i] == null)
                particleSystems.RemoveAt(i);

            if (particleSystems.Count == 0)
                taskPoluentesCompleted();
        }
    }
}
