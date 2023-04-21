using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 _initialRotation;

    private void Awake()
    {
        _initialRotation = transform.eulerAngles;
    }

    void Update()
    {
        var playerPosition = playerTransform.position;
        var eulerAngles = playerTransform.eulerAngles;
        transform.position = new Vector3(playerPosition.x, playerPosition.y, playerPosition.z);
        transform.eulerAngles = new Vector3(eulerAngles.x+ _initialRotation.x, eulerAngles.y+ _initialRotation.y, 0);
    }
}
