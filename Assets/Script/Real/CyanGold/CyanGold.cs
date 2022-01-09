using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanGold : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Renderer>().material.color == Color.cyan)
        {
            UIController.puan += 10;

        }
        else
        {
            UIController.can--;
        }
    }
}
