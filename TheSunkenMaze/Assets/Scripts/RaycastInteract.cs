using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class RaycastInteract : MonoBehaviour
{
    [SerializeField]
    float interactRange = 4;

    [SerializeField]
    TextMeshProUGUI interactText;

    [SerializeField]
    TextMeshProUGUI collected;

    [SerializeField]
    Image crosshairInact;

    [SerializeField]
    Image crosshairAct;

    [SerializeField]
    MeshRenderer slingshot;

    public ObjectCounter objectReference;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crosshairInact.enabled = true;
        crosshairAct.enabled = false;
        interactText.enabled = false;
        collected.enabled = false;
        slingshot.enabled = false;
        //
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(ray, out hit, interactRange))
        {
            if(hit.collider.gameObject.tag == "Interactable")
            {
                interactText.enabled = true;
                crosshairInact.enabled = false;
                crosshairAct.enabled = true;
                if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.layer == 7 && objectReference.gems >= 1)
                {
                    hit.collider.gameObject.GetComponent<Animator>().SetTrigger("Interact");
                    objectReference.gems -= 1;
                    objectReference.gemCount.SetText(objectReference.gems.ToString());
                }
                else if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.layer == 6)
                {
                    objectReference.gems += 1;
                    Destroy(hit.collider.gameObject);
                    objectReference.gemCount.SetText(objectReference.gems.ToString());
                }
                else if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.layer == 8)
                {
                    objectReference.stones += Random.Range(1, 6);
                    Destroy(hit.collider.gameObject);
                    objectReference.stoneCount.SetText(objectReference.stones.ToString());
                }
                else if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.layer == 9)
                {
                    objectReference.key = true;
                    collected.enabled = true;
                }
                else if (Input.GetKeyDown(KeyCode.E) && objectReference.key == true && hit.collider.gameObject.layer == 10)
                {
                    objectReference.key = true;
    
                }
                else if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.layer == 11) 
                {
                objectReference.slingShot = true;
                    Destroy(hit.collider.gameObject);
                    slingshot.enabled = true;
                }

            }
        }
        else
        {
            interactText.enabled = false;
            crosshairInact.enabled = true;
            crosshairAct.enabled = false;
        }
                
    }
}
