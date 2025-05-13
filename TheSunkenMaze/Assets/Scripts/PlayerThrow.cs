using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
 




    [SerializeField] GameObject projectile;
    Transform spawnPoint;

    public float timer;
    float curTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame curTime >= timer
    void Update()
    {

        curTime += Time.deltaTime;
      

        if (Input.GetMouseButtonDown(0)) 
        {
            Instantiate(projectile, transform.position, transform.rotation);
            curTime = 0;
        }
        

    }
}
