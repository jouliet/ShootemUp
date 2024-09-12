using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Vector2 _speed;
    public Vector2 Speed {
        get {
        return this._speed;
        }
        private set {
        this._speed = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Speed = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (Input.GetKey("space"))
        {
            GetComponent<BulletGun>().Fire();
        }
    }
}
