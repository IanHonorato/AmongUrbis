using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixeira : TaskReciclagem
{

    public string tagLixo;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagLixo))
        {
            //colidiu com o objeto desejado.
            Destroy(other.gameObject);
        }
        else 
        {
            resetTask();
            Debug.Log("errou");
        }
    }
}
