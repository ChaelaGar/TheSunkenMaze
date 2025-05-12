using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class AnimationSpeakers : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAnimation ()
    {
        anim.SetTrigger("Begin");


    }
}
