using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InteractableTable : MonoBehaviour
{
    public GameObject item;
    private bool inside;
    private BagSystem bag;

    void Start()
    {
        bag = GameObject.FindGameObjectWithTag("Player").GetComponent<BagSystem>();
    }

    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && inside)
        {
            for (int i = 0; i < bag.slots.Length; i++)
            {
                if (!bag.isFill[i])
                {
                    bag.isFill[i] = true;
                    Instantiate(item, bag.slots[i].transform, false);
                    break;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inside = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inside = false;
    }
}
