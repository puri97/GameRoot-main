using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootMovement : MonoBehaviour
{
    //Intialize through the inspector the growth speed of the root
    [SerializeField] private float Speed;
    //Initialize through the inspector of the turn speed of the root
    [SerializeField] private float TurnSpeed;

    //direction the root is traveling
    private Vector3 direction;

    void Start()
    {
        //Initialize the root going downward
        direction = Vector3.down;
    }

    // Player control for moving the root
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction.x -= TurnSpeed;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            direction.x += TurnSpeed;
        }

    }
    //Late update function to update root position
    private void LateUpdate()
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }

    //future implementation when hitting an obstacle,
    //ex) Rock or hard soil
    //Dont worry about this yet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
