using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    [Header ("movement data")]
    public float moveSpeed;
    public float rotationSpeed;

    public float horizontalInput;
    public float verticalInput;

    [Space]
    public LayerMask WhatIsAimMask;
    public Transform aimTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        UpdateAim();
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (verticalInput < 0)
            horizontalInput = -Input.GetAxis("Horizontal");
        
        
    }

    private void FixedUpdate()
    {
        Vector3 movement = transform.right * moveSpeed * verticalInput;

        rb.linearVelocity = movement;

        transform.Rotate(0 ,horizontalInput * rotationSpeed, 0);
    }

    private void UpdateAim()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit , Mathf.Infinity, WhatIsAimMask))
        {
            float fixedY = aimTransform.position.y;
            aimTransform.position = new Vector3(hit.point.x, fixedY, hit.point.z);
        }
    }
}
