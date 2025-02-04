using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    Rigidbody projectile;
    [SerializeField]
    float bulletSpeed = 10f;
    [SerializeField]
    GameObject player;
    Vector3 rot;
    Vector3 pos;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update() { }
} 
    /*{
        if (Input.GetButton("Fire1"))
        {
           //Rigidbody instantiatedProjectile = Instantiate(projectile,Camera.main.transform.position, Camera.main.transform.forward)) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, bulletSpeed));
       
            
        }
    }
}*/
