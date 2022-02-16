using UnityEngine;
using UnityEngine.InputSystem;

public class Northbtn : MonoBehaviour
{
    private bool inside = false;
    public static SpriteRenderer spriteRenderer;
    public static bool pressed = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (inside == true && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (Eastbtn.pressed == false && Westbtn.pressed == false && Southbtn.pressed == false)
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        inside = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        inside = false;
    }
}