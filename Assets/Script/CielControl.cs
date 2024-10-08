using UnityEngine;
using UnityEngine.InputSystem;

public class CielControl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float speed;
    [SerializeField] private CielInput cielInput;
    [SerializeField] private Vector2 movement;

    private void Awake()
    {
        cielInput = new CielInput();
    }

    private void OnEnable()
    {
        cielInput.Player.Enable();
    }

    private void OnDisable()
    {
        cielInput.Player.Disable();
    }

    // Update is called once per frame
    private void Update()
    {
        #region Controller
        Vector2 dir = Vector2.zero;
        //Up Down Animation

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            if (animator.GetBool("Front"))
            {
                animator.SetBool("Front", false);
            }
            if (animator.GetBool("Left"))
            {
                animator.SetBool("Left", false);
            }
            if (animator.GetBool("Right"))
            {
                animator.SetBool("Right", false);
            }
            animator.SetBool("Back", true);
            animator.SetFloat("BackSpeed", 0.01f);
        }
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            animator.SetFloat("BackSpeed", 0);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            if (animator.GetBool("Left"))
            {
                animator.SetBool("Left", false);
            }
            if (animator.GetBool("Back"))
            {
                animator.SetBool("Back", false);
            }
            if (animator.GetBool("Right"))
            {
                animator.SetBool("Right", false);
            }
            animator.SetBool("Front", true);
            animator.SetFloat("FrontSpeed", 0.01f);
        }
        if (Keyboard.current.sKey.wasReleasedThisFrame)
        {
            animator.SetFloat("FrontSpeed", 0);
        }

        //Left Right Animation

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            if (animator.GetBool("Front"))
            {
                animator.SetBool("Front", false);
            }
            if (animator.GetBool("Back"))
            {
                animator.SetBool("Back", false);
            }
            if (animator.GetBool("Left"))
            {
                animator.SetBool("Left", false);
            }
            animator.SetBool("Right", true);
            animator.SetFloat("RightSpeed", 0.01f);
        }
        if (Keyboard.current.dKey.wasReleasedThisFrame)
        {
            animator.SetFloat("RightSpeed", 0);
        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            if (animator.GetBool("Front"))
            {
                animator.SetBool("Front", false);
            }
            if (animator.GetBool("Back"))
            {
                animator.SetBool("Back", false);
            }
            if (animator.GetBool("Right"))
            {
                animator.SetBool("Right", false);
            }
            animator.SetBool("Left", true);
            animator.SetFloat("LeftSpeed", 0.01f);
        }
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            animator.SetFloat("LeftSpeed", 0);
        }

        #endregion Controller
    }

    private void FixedUpdate()
    {
        movement = cielInput.Player.Move.ReadValue<Vector2>();
    }
}