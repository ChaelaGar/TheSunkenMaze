using UnityEngine;

public class Raycastshoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            if (Physics.Raycast(ray, out hit))
            {
                // Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    hit.collider.gameObject.GetComponent<EnemyHP>().TakeDamage(1);
                }

            }
        }
    }
}
