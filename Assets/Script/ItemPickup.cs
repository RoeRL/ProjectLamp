using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private BagSystem bag;

    private void Start()
    {
        bag = GameObject.FindGameObjectWithTag("Player").GetComponent<BagSystem>();
    }
}
