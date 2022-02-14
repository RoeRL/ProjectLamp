using UnityEngine;
using UnityEngine.InputSystem;

public class Westbtn : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public static bool pressed = false;

    private void LateUpdate()
    {
        if (pressed == false)
        {
            spriteRenderer.color = new Color(0, 0, 0, 1);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (Eastbtn.pressed == true && Southbtn.pressed == false && Northbtn.pressed == true)
            {
                pressed = true;
                spriteRenderer.color = new Color(0, 1, 0, 1);
            }
            else
            {
                pressed = false;
                Eastbtn.pressed = false;
                Southbtn.pressed = false;
                Northbtn.pressed = false;
                spriteRenderer.color = new Color(1, 0, 0, 1);
            }
        }
    }
}
