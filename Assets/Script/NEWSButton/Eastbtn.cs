using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Eastbtn : MonoBehaviour
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
            if (Northbtn.pressed == true && Westbtn.pressed == false && Southbtn.pressed == false)
            {
                pressed = true;
                spriteRenderer.color = new Color(0, 1, 0, 1);
            }
            else
            {
                pressed = false;
                Westbtn.pressed = false;
                Southbtn.pressed = false;
                Northbtn.pressed = false;
                spriteRenderer.color = new Color(1, 0, 0, 1);
            }
        }
    }
}
