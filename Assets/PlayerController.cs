using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    private float horizontal, vertical;
    private Vector3 movementDir;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        HandleMovement();
    }
    private void HandleMovement()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movementDir = new Vector3(horizontal, 0, vertical).normalized;

        rb.MovePosition(rb.position + movementDir.normalized * moveSpeed * Time.deltaTime);
    }
}
