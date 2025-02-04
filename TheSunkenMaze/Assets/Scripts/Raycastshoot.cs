using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Raycastshoot : MonoBehaviour
{
    /*[SerializeField]
    private bool addBulletSpread = true;
    [SerializeField]
    private Vector3 bulletSpreadVarience = new Vector3(0.1f, 0.1f, 0.1f);
    [SerializeField]
    private ParticleSystem shootingSystem;
    [SerializeField]
    private Transform BulletSpawnPoint;
    [SerializeField]
    private ParticleSystem impact;
    [SerializeField]
    private TrailRenderer rockTrail;
    [SerializeField]
    private float shootDelay = 0.5f;
    [SerializeField]
    private LayerMask mask;*/
    public ObjectCounter objectReference;

    private float lastShoot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && objectReference.stones > 0 && objectReference.slingShot == true)
        {
            //Shoot();
            objectReference.stones -= 1;
            objectReference.stoneCount.SetText(objectReference.stones.ToString());
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            if (Physics.Raycast(ray, out hit))
            {
                // Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Enemy" )
                {
                    
                    hit.collider.gameObject.GetComponent<EnemyHP>().TakeDamage(1);
                }

            }
        }
    }
}
   /* public void Shoot()
    {
        if (lastShoot + shootDelay < Time.time)
        {

            Vector3 direction = GetDirection();
            if (Physics.Raycast(BulletSpawnPoint.position, direction, out RaycastHit hit, float.MaxValue, mask))
            {
                TrailRenderer trail = Instantiate(rockTrail, BulletSpawnPoint.position, Quaternion.identity);

                StartCoroutine(SpawnTrail(trail, hit));

            }

        }
        


    }
    private Vector3 GetDirection()

    {
        Vector3 direction = transform.forward;

        if (addBulletSpread)
        {
            direction += new Vector3(
                Random.Range(-bulletSpreadVarience.x, -bulletSpreadVarience.x),
                  Random.Range(-bulletSpreadVarience.x, -bulletSpreadVarience.y),
                    Random.Range(-bulletSpreadVarience.x, -bulletSpreadVarience.z)
                    );
            direction.Normalize();
        }
        return direction;
    }
    private IEnumerator SpawnTrail(TrailRenderer Trail, RaycastHit hit)
    {
        float time = 0;
        Vector3 startPosition = Trail.transform.position;
        while (time < 1)
        {
            Trail.transform.position = Vector3.Lerp(startPosition, hit.point, time);
            time += Time.deltaTime / Trail.time;

            yield return null;
        }
        Trail.transform.position = hit.point;
        Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(Trail.gameObject, Trail.time);
    }
}*/
