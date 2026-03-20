using System;
using UnityEngine;

public class playerfollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 5, transform.position.y, player.transform.position.z);
    }
}
