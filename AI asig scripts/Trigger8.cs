using UnityEngine;
using System.Collections;

public class Trigger8 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        //Aquire the agent/agents as GameObjects
        GameObject agent4 = GameObject.FindGameObjectWithTag("Agent4");

        //Aquire the agents scripts
        AgentReceiver4 a = agent4.GetComponent<AgentReceiver4>();

        //Change the agents states
        a.consoleMsg(3);
    }
}
