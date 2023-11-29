using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPS
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Refferences")]
        [SerializeField] private Transform orientation;
        [SerializeField] private Transform playerObj;
        [SerializeField] private Rigidbody rb;
        [Range(5, 10)]
        [SerializeField] private float moveSpeed;
        [SerializeField] private float jumpForce;

        private Vector3 movementDir;
        private const float WALKSPEED = 6;
        private const float RUNSPEED = 10;
        private float horizontal;
        private float vertical;
        private float playerRotationSpeed;
        // Start is called before the first frame update
        void Start()
        {
            moveSpeed = WALKSPEED;
        }

        // Update is called once per frame
        void Update()
        {
            WalkOrRun();
        }
        private void FixedUpdate()
        {
            MovevementController();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
        private void MovevementController()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            movementDir = new Vector3(horizontal, 0, vertical).normalized;
            rb.MovePosition(rb.position + movementDir.normalized * moveSpeed * Time.deltaTime);
        }
        private void WalkOrRun()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                switch (moveSpeed)
                {
                    case (WALKSPEED):
                        moveSpeed = RUNSPEED;
                        break;
                    case (RUNSPEED):
                        moveSpeed = WALKSPEED;
                        break;
                }
            }

        }
        private void Jump()
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}