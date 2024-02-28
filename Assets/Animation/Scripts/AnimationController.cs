using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private float animationProgress = 0f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
    }

    public void setSunTrue()
    {
        animator.SetBool("Sun",true);
    }

    public void setSunFalse()
    {
        animator.SetBool("Sun",false);
    }

    public void SetWaterTrue()
    {
        animator.SetBool("Water",true);
    }
    
    public void SetWaterFalse()
    {
        animator.SetBool("Water",false);
    }

}
