using UnityEngine;
using UnityEngine.InputSystem;

public class Westbtn : MonoBehaviour
{
    public static SpriteRenderer spriteRenderer;
    public static bool pressed = false;
    private bool inside = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (inside == true && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (Eastbtn.pressed == true && Southbtn.pressed == false && Northbtn.pressed == true)
            {
                pressed = true;
                spriteRenderer.color = new Color(0, 1, 0, 1);
            }
            else
            {
                StartCoroutine(ButtonPuzzleManager.ResetButton());
            }
        }
    }

    private void LateUpdate()
    {
        if (pressed == false)
        {
            spriteRenderer.color = new Color(1, 1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inside = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inside = false;
    }
}