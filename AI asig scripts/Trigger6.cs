using UnityEngine;
using System.Collections;

public class Trigger6 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        //Aquire the agent/agents as GameObjects
        GameObject agent2 = GameObject.FindGameObjectWithTag("Agent2");
        GameObject agent3 = GameObject.FindGameObjectWithTag("Agent3");

        //Aquire the agents scripts
        AgentReceiver2 a = agent2.GetComponent<AgentReceiver2>();
        AgentReceiver3 b = agent3.GetComponent<AgentReceiver3>();

        //Change the agents states
        a.consoleMsg(3);
        b.consoleMsg(3);
    }
}
