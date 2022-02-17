using UnityEngine;
using UnityEngine.InputSystem;

public class Lockpick : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float moveTo = -300f;

    // Start is called before the first frame update
    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LockCorner")
        {
            moveTo = 300f;
        }
        if (collision.gameObject.name == "LockCorner2")
        {
            moveTo = -300f;
        }
        if (collision.gameObject.name == "Slot1 collider")
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Debug.Log("Gotcha!");
            }
        }
    }

    private void LateUpdate()
    {
        rigidbody2d.AddForce(new Vector2(moveTo, 0f) * Time.deltaTime);
    }
}