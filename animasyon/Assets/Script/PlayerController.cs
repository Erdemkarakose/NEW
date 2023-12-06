using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    bool hasStartedWalking = false;
    float moveSpeed = 0.2f;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (hasStartedWalking)
            {
                
                animator.SetBool("isWalking", false);
                hasStartedWalking = false;                
            }
            else
            {
                
                hasStartedWalking = true;
                animator.SetBool("isWalking", true);
            }
        }

        if (hasStartedWalking)
        {
            
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
