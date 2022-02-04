using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CielControl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float speed;
    [SerializeField] private CielInput cielInput;
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private Vector2 movement;
    [SerializeField] private BoxCollider2D collider;

    private void Awake()
    {
        cielInput = new CielInput();
        collider = GetComponent<BoxCollider2D>();
        rigidbody = GetComponent<Rigidbody2D>();
        if (rigidbody is null)
        {
            Debug.LogError("RigidBody is not found!");
        }
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
    void Update()
    {
        #region Controller
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

            collider.size = new Vector2(0.8f, 2f);
            collider.offset = new Vector2(-0.05f, 0.5f);
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

            collider.size = new Vector2(0.8f, 2f);
            collider.offset = new Vector2(-0.05f, -0.5f);
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

            collider.offset = new Vector2(0.5f, -0.05f);
            collider.size = new Vector2(2f, 0.8f);
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

            collider.offset = new Vector2(-0.5f, -0.05f);
            collider.size = new Vector2(2f, 0.8f);
        }
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            animator.SetFloat("LeftSpeed", 0);
        }
        #endregion
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "MejaBundar")
        {
            Debug.Log("Berhasil");
        }
    }

    private void FixedUpdate()
    {
        movement = cielInput.Player.Move.ReadValue<Vector2>();
        rigidbody.velocity = movement * speed;
    }
}
