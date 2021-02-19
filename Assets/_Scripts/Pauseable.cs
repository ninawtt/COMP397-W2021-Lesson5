using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pauseable : MonoBehaviour
{
    public List<MonoBehaviour> scripts;
    public List<UnityEngine.AI.NavMeshAgent> agents;
    public bool isGamePaused;

    // Start is called before the first frame update
    void Start()
    {
        isGamePaused = false;
    }

    public void TogglePause()
    {
        isGamePaused = !isGamePaused;

        foreach(var script in scripts) {
            script.enabled = !isGamePaused;
        }
        foreach(var agent in agents) {
            agent.enabled = !isGamePaused;
        }
    }
}
