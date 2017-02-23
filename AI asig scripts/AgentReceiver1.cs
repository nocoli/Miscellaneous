using UnityEngine;
using System.Collections;

public class AgentReceiver1 : MonoBehaviour {

    private int state;
    private Vector3 patrol_start;
    private Vector3 patrol_end;
    private Vector3 target_patrol;
    private Vector3 room_entry;
    private Vector3 calm_seat;
    float speed;

    // Use this for initialization
    void Start()
    {
        state = 0;
        patrol_start = new Vector3(1405f, 8.9f, 1323f);
        patrol_end = new Vector3(1405f, 8.9f, 1312f);
        room_entry = new Vector3(1406f, 8.9f, 1317.1f);
        calm_seat = new Vector3(1401f, 8.9f, 1323f);
        target_patrol = patrol_end;
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Initial state
        if (state == 0)
        {
            patrol();
        }
        else
        {
            switch (state)
            {
                case 1:
                    speedUp();
                    break;
                case 2:
                    calmDown();
                    break;
                case 3:
                    greetPlayer();
                    break;
            }
        }
    }

    //Public method used to change the state of the agent
    public void consoleMsg(int q)
    {
        state = q;
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

    //Speed up the patrol
    public void speedUp()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
        speed = 4;
        patrol();
    }

    //Put the agent over in the corner
    public void calmDown()
    {
        GetComponent<Renderer>().material.color = Color.green;
        transform.position = Vector3.MoveTowards(transform.position, calm_seat, 2.0f * Time.deltaTime);
    }

    //Brings NPC to the door
    public void greetPlayer()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        transform.position = Vector3.MoveTowards(transform.position, room_entry, Time.deltaTime * 2f);
        if (transform.position == room_entry)
        {
            StartCoroutine("waitFiveSeconds");
        }
    }

    IEnumerator waitFiveSeconds()
    {
        yield return new WaitForSeconds(5);
        GetComponent<Renderer>().material.color = Color.white;
        state = 0;
    }
}
