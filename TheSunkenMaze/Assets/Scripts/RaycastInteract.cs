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
    Image crosshairInact;
    [SerializeField]
    Image crosshairAct;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crosshairInact.enabled = true;
        crosshairAct.enabled = false;
        interactText.enabled = false;
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
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Animator>().SetTrigger("Interact");
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
