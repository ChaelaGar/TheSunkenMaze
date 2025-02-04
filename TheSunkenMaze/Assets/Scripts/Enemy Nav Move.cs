using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
public class EnemyNavMove : MonoBehaviour
{
    [SerializeField]
    float chaseDis = 10;
    Vector3 home;
    GameObject player;
    NavMeshAgent agent;
    Animator anim;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        home = transform.position;
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentsInChildren<Animator>()[0];
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = player.transform.position - transform.position;
        if (dir.magnitude < chaseDis)
        {
            agent.destination = player.transform.position;
            anim.Play("New State 0");
        }
       else
        {
            agent.destination = home;
           
        }
    }
}
