using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{

    public Transform player;
    public float playerDistance;
    public float rotationDamping;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);
        //Have the enmeny look at the player
        if (playerDistance < 15.0f)
        {
            lookAtPlayer();
        }
        if (playerDistance < 12.0f)
        {
            chasePlayer();
        }

    }
    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        //Rotate the enmey
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
    }
    void chasePlayer()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}



