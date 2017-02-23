using UnityEngine;
using System.Collections;

public class Trigger4 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        //Aquire the agent/agents as GameObjects
        GameObject agent2 = GameObject.FindGameObjectWithTag("Agent2");
        GameObject agent3 = GameObject.FindGameObjectWithTag("Agent3");
        GameObject agent4 = GameObject.FindGameObjectWithTag("Agent4");

        //Aquire the agents scripts
        AgentReceiver2 a = agent2.GetComponent<AgentReceiver2>();
        AgentReceiver3 b = agent3.GetComponent<AgentReceiver3>();
        AgentReceiver4 c = agent4.GetComponent<AgentReceiver4>();

        //Change the agents states
        a.consoleMsg(1);
        b.consoleMsg(1);
        c.consoleMsg(1);
    }
}
