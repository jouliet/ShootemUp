using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engines : MonoBehaviour
{
    Vector2 Speed;
    Vector2 Position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Position = GetComponent<Transform>().position;
        Speed = GetComponent<InputController>().Speed;

        transform.position = Position + Speed*Time.deltaTime*GetComponent<BaseAvatar>().MaxSpeed;        
    }
}
