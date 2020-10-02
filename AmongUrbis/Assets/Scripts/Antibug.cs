using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Antibug : MonoBehaviour
{
    private void OnTriggerEnter() {
        SceneManager.LoadScene("AmongUrbis");
    }
}
