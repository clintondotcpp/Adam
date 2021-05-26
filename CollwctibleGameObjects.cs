using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private int _speed;
    public static int _score;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);
    }
}
