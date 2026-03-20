using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    [Header ("Gun data")]
    [SerializeField] private Transform gunpoint;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject bulletPrefab;


    [Header ("movement data")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    private float horizontalInput;
    private float verticalInput;

    [Header ("tower data")]
    [SerializeField] private Transform towertransformation;
    [SerializeField] private float towerrotationspeed;

    [Header ("aim data")]
    [SerializeField] private LayerMask WhatIsAimMask;
    [SerializeField] private Transform aimTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        UpdateAim();
        CheckInputs();

    }

    private void CheckInputs()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
            Shoot();

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (verticalInput < 0)
            horizontalInput = -Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        ApplyMovement();
        ApplyBodyRotation();
        ApplyTowerRotation();
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, gunpoint.position, gunpoint.rotation);
        bullet.GetComponent<Rigidbody>().linearVelocity = gunpoint.forward * bulletSpeed;

        Destroy(bullet,7);
    }

    private void ApplyTowerRotation()
    {
        Vector3 direction = aimTransform.position - towertransformation.position;
        direction.y = 0;

        Quaternion tragetRotation = Quaternion.LookRotation(direction);

        towertransformation.rotation = Quaternion.RotateTowards(towertransformation.rotation, tragetRotation, towerrotationspeed);
    }

    private void ApplyBodyRotation()
    {
        transform.Rotate(0, horizontalInput * rotationSpeed, 0);
    }

    private void ApplyMovement()
    {
        Vector3 movement = transform.forward * moveSpeed * verticalInput;
        rb.linearVelocity = movement;
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