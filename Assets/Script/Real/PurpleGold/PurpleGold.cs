using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurpleGold : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Renderer>().material.color == new Color32(192, 0, 184, 255))
        {
            UIController.puan += 10;
           
        }
        else
        {
            UIController.can--;
        }
    }
}
