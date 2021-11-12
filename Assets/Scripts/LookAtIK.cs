using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class LookAtIK : MonoBehaviour
{
    protected Animator animator;

    public bool IkActive = false;
    public Transform LookObj = null;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK()
    {
        if (animator)
        {
            if (IkActive)
            {
                if (LookObj != null)
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(LookObj.position);
                }
            }
            else
            {
                animator.SetLookAtWeight(0);
            }
        }
    }
}
