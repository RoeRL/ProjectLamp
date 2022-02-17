using UnityEngine;
using UnityEngine.InputSystem;

public class Puzzlebtn : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                spriteRenderer.color = new Color(1, 0, 0, 1);
            }
        }
    }
}