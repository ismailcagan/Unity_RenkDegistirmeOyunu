using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowGold : MonoBehaviour
{
    private void Awake()
    {
    }
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Renderer>().material.color == Color.yellow)
        {
            UIController.puan += 10;
        
        }
        else
        {
            UIController.can--;
        }
    }
}
