using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    public int vida = 3;
    public bool isClear = false;
    private void OnMouseDown()
    {
        if (GetComponentInChildren<ParticleSystem>() != null)
        {
            var particulas = GetComponentInChildren<ParticleSystem>().main;

            if (vida == 2)
                particulas.startLifetime = 2.5f;

            if (vida == 1)
                particulas.startLifetime = 1.0f;

            if (vida == 0)
            {
                isClear = true;
                Destroy(GetComponentInChildren<ParticleSystem>());
            }
            vida--;
        }
    }
}
