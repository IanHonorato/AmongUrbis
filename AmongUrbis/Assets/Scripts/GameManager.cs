using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<EventSystem> tasks;
    public Text victory;
    void Start()
    {
        victory.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameComplete();
    }

    void gameComplete() {
        for (int i = 0; i < tasks.Count; i++) {
            if (tasks[i] == null) {
                tasks.RemoveAt(i);
            }
            if (tasks.Count == 0) {
                //game acabou. Parabens!!
                victory.enabled = true;
                Debug.Log("ACABOU O JOGO PARABENS FAZER TELA");
            }
        }
    }
}
