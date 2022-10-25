using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputsytem : MonoBehaviour
{
    [SerializeField] private float speed;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.right * horizontal + transform.forward * vertical;
        transform.Translate(movement * speed * Time.deltaTime);

        if(movement != Vector3.zero)
        {
            animator.SetBool("running", true);
        }
        else
        {
            animator.SetBool("running", false);
        }
    }
}
