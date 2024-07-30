using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeSystem : Sounds
{
    [SerializeField] private Animator anim;
    [SerializeField] private ParticleSystem particle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Smoke") && !_audioSource.isPlaying)
        {
            anim.SetBool("Smoke",true);
        }

        if(Input.GetKeyUp(KeyCode.Mouse0)) anim.SetBool("Smoke", false);

        if (Input.GetKeyDown(KeyCode.F)) anim.SetTrigger("Droped");
    }

    private void tyaga()
    {
        PlaySound(0, 3);
    }
    
    private void blow()
    {
        PlaySound(3, 6);
        particle.Play();
    }
}
