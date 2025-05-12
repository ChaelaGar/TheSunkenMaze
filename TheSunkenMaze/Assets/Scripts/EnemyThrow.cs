using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrow : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    float pursuitDis;
    [SerializeField]
    float retreatDis;
    [SerializeField]
    float safeDis;




    [SerializeField] GameObject projectile;
    Transform spawnPoint;

    public float timer;
    float curTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        curTime += Time.deltaTime;
        Vector3 dir = player.transform.position - transform.position;

        if (curTime >= timer)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            curTime = 0;
        }
        

    }
}
