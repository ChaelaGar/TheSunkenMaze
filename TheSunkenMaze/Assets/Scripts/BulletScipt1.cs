using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class BulletScipt1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 2000);
    }

    // Update is called once per frame
   private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player hit!");
            Destroy(gameObject);
        }
        else if (collision.gameObject.layer == 12)
        {
            Destroy(gameObject);
        }
    }
}
