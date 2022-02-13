using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private bool autoFindPlayer;

    [SerializeField] private GameObject playerGameObject;

    [SerializeField] private bool autoOffsetCamera;
    [SerializeField] private Vector3 cameraOffset;

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