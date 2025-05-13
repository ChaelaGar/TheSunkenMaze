using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementNew : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    float pursuitDis;
    [SerializeField]
    float retreatDis;
    [SerializeField]
    float safeDis;

    NavMeshAgent me;
    [SerializeField]
    float defaultSpeed;

    [SerializeField]
    float timer;
    float time;

   

    // Start is called before the first frame update
    void Start()
    {
        me = GetComponent<NavMeshAgent>();
    defaultSpeed = me.speed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.transform.position - transform.position;
        transform.LookAt(player.transform.position);
        if (dir.magnitude <= pursuitDis && dir.magnitude >= safeDis)
        {
            me.isStopped = false;
            me.destination = player.transform.position;
         me.speed = defaultSpeed;

        }

        else if (dir.magnitude <= retreatDis)
        {
            me.isStopped = false;
            
            me.speed = defaultSpeed * 2;
            me.destination -= player.transform.position.normalized;

        }

        else
        {
            me.isStopped = true;
            
            Debug.Log("else");

        }
    }
}
