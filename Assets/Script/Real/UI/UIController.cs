using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text puantxt;
    public static int puan;
    public Text cantxt;
    public static int can;

    private void Awake()
    {
        puan = 0;
        can = 10;
    }
    private void Update()
    {
        puantxt.text = puan.ToString();
        cantxt.text = can.ToString();
    }

}
