using UnityEngine;
using System.Collections;

public class AgentReceiver2 : MonoBehaviour {

    private int state;
    private Vector3 patrol_start;
    private Vector3 patrol_end;
    private Vector3 target_patrol;
    private Vector3 neutral_pos;
    private Vector3 block_door;
    float speed;

    // Use this for initialization
    void Start()
    {
        state = 0;
        patrol_start = new Vector3(1424f, 8.9f, 1319.5f);
        patrol_end = new Vector3(1431f, 8.9f, 1322f);
        neutral_pos = new Vector3(1428, 8.9f, 1321.7f);
        block_door = new Vector3(1423, 8.9f, 1318);
        target_patrol = patrol_end;
        speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //Initial state
        if (state == 0)
        {
            neutral();
        }
        else
        {
            switch (state)
            {
                case 1:
                    patrol();
                    break;
                case 2:
                    blockDoor();
                    break;
                case 3:
                    speedPatrol();
                    break;
            }
        }
    }

    //Public method used to change the state of the agent
    public void consoleMsg(int q)
    {
        state = q;
    }

    //Agents nueatral state and position
    public void neutral()
    {
        transform.position = Vector3.MoveTowards(transform.position, neutral_pos, 2.0f * Time.deltaTime);
    }

    //Moves the agent to block the entrance to the room
    public void blockDoor()
    {
        transform.position = Vector3.MoveTowards(transform.position, block_door, 2.0f * Time.deltaTime);
    }

    //Makes the agent patrol between two points
    public void patrol()
    {
        Vector3 targetDir;
        Vector3 newDir;
        // if at start
        if (Vector3.Distance(transform.position, patrol_start) < 0.1f)
        {
            target_patrol = patrol_end;
        }
        if (Vector3.Distance(transform.position, patrol_end) < 0.1f)
        {
            target_patrol = patrol_start;
        }

        targetDir = target_patrol - transform.position;
        newDir = Vector3.RotateTowards(transform.forward, targetDir, 2.0f * Time.deltaTime, 0.0F);
        transform.rotation = Quaternion.LookRotation(newDir);
        transform.position = Vector3.MoveTowards(transform.position, target_patrol, Time.deltaTime * speed);
    }

    //Speeds up the patrol function
    public void speedPatrol()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        speed = 6;
        patrol();
    }
}
