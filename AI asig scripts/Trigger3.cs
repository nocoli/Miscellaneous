using UnityEngine;
using System.Collections;

public class Trigger3 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        //Aquire the agent/agents as GameObjects
        GameObject agents1 = GameObject.FindGameObjectWithTag("Agent1");
        GameObject agent4 = GameObject.FindGameObjectWithTag("Agent4");

        //Aquire the agents scripts
        AgentReceiver1 a = agents1.GetComponent<AgentReceiver1>();
        AgentReceiver4 c = agent4.GetComponent<AgentReceiver4>();

        //Change the agents states
        a.consoleMsg(3);
        c.consoleMsg(2);
    }
}
