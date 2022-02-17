using System.Collections;
using UnityEngine;

public class ButtonPuzzleManager : MonoBehaviour
{
    public static IEnumerator ResetButton()
    {
        Northbtn.spriteRenderer.color = new Color(1, 0, 0, 1);
        Eastbtn.spriteRenderer.color = new Color(1, 0, 0, 1);
        Westbtn.spriteRenderer.color = new Color(1, 0, 0, 1);
        Southbtn.spriteRenderer.color = new Color(1, 0, 0, 1);
        yield return new WaitForSeconds(2);
        Northbtn.pressed = false;
        Eastbtn.pressed = false;
        Westbtn.pressed = false;
        Southbtn.pressed = false;
    }
}