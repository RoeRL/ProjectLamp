using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] bool autoFindPlayer;
    [SerializeField] GameObject playerGameObject;

    [SerializeField] bool autoOffsetCamera;
    [SerializeField] Vector3 cameraOffset;

    private void Awake()
    {
        if (autoFindPlayer)
        {
            playerGameObject = GameObject.FindGameObjectWithTag("Player");
        }

        if (autoOffsetCamera && autoFindPlayer)
        {
            cameraOffset = (transform.position - playerGameObject.transform.position);
        }
    }

    private void LateUpdate()
    {
        transform.position = (playerGameObject.transform.position + cameraOffset);
    }
}
