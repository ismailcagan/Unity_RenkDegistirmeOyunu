using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 100f;
    [SerializeField] float jumpPower = 300f;
    Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        _rigidbody.AddForce(new Vector3(-1, 0, 0)*moveSpeed*Time.deltaTime);
        Jump();
        
    }
    public void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.AddForce(new Vector3(0, 1, 0) * jumpPower);
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "EnemyCyan")
        {
           Color cyancolor=gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (other.gameObject.tag == "EnemyPurple")
        {
           Color purplecolor= gameObject.GetComponent<Renderer>().material.color = new Color32(192, 0, 184, 255);
        }
        if (other.gameObject.tag == "EnemyYellow")
        {
           Color yellowcolor= gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

}