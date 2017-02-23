using UnityEngine;
using System.Collections;

public class Trigger2 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        //Aquire the agent/agents as GameObjects
        GameObject agents1 = GameObject.FindGameObjectWithTag("Agent1");

        //Aquire the agents scripts
        AgentReceiver1 a = agents1.GetComponent<AgentReceiver1>();

        //Change the agents states
        a.consoleMsg(2);
    }
}
