using UnityEngine;
using System.Collections;

public class AgentReceiver4 : MonoBehaviour {

    private int state;
    private Vector3 patrol_start;
    private Vector3 patrol_end;
    private Vector3 centre_pos;
    private Vector3 target_patrol;
    private Vector3 block_door;
    private Vector3 comp_seat;
    private Vector3 leave_spot;
    float speed;

    // Use this for initialization
    void Start()
    {
        state = 0;
        patrol_start = new Vector3(1414.2f, 8.9f, 1319.47f);
        patrol_end = new Vector3(1414.2f, 8.9f, 1328.6f);
        block_door = new Vector3(1414.2f, 8.9f, 1319.47f);
        comp_seat = new Vector3(1414.9f, 8.9f, 1331.5f);
        leave_spot = new Vector3(1414.9f, 6f, 1331.5f);
        target_patrol = patrol_end;
        speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //Initial state
        if (state == 0)
        {
            blockEntrance();
        }
        else
        {
            switch (state)
            {
                case 1:
                    patrol();
                    break;
                case 2:
                    computer();
                    break;
                case 3:
                    leave();
                    break;
            }
        }
    }

    //Public method used to change the state of the agent
    public void consoleMsg(int q)
    {
        state = q;
    }

    //Blocks the player from moving down the hallway
    public void blockEntrance()
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

    //Sends the agent over to the levels computer
    public void computer()
    {
        transform.position = Vector3.MoveTowards(transform.position, comp_seat, 2.0f * Time.deltaTime);
    }

    //Sends the agent out of plyers vision by lowering through the ground
    public void leave()
    {
        transform.position = Vector3.MoveTowards(transform.position, leave_spot, 2.0f * Time.deltaTime);
    }

}
