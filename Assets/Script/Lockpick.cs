using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lockpick : MonoBehaviour
{
    public Vector2 targetPosition;
    public float speed;
    private Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(position, targetPosition, moveSpeed);
    }
}
