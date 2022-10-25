using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    CharacterController controller;
    Rigidbody rb;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        #region controller movement
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = transform.right * x + transform.forward * z;

        controller.Move(moveDir * speed * Time.deltaTime);
        #endregion

        #region rigidbody movement
        float xaxis = Input.GetAxisRaw("Horizontal");
        float zaxis = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * xaxis + transform.forward * zaxis;

        rb.velocity = move * speed * Time.deltaTime;
        #endregion

        #region translate movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.right * horizontal + transform.forward * vertical;
        transform.Translate(movement * speed * Time.deltaTime);
        #endregion
    }
}
