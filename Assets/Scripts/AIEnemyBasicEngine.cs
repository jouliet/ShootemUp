using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemyBasicEngine : MonoBehaviour
{
    Vector2 Speed;
    Vector2 Position;

    // Start is called before the first frame update
    void Start()
    {
        Speed = new Vector2(-1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Position = GetComponent<Transform>().position;

        transform.position = Position + Speed*Time.deltaTime*GetComponent<BaseAvatar>().MaxSpeed; 
    }
}
