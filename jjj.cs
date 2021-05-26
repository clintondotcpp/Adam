using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    public GameObject spherePrefab;
    public Vector3 firePos;

    [SerializeField]
    private float _speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hInput, vInput, 0));

        if (transform.position.x > 8.5f)
        {
            transform.position = new Vector3(8.5f, transform.position.y, 0);
        }

        if (transform.position.x < -8.5f)
        {
            transform.position = new Vector3(-8.5f, transform.position.y, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spherePrefab, firePos, Quaternion.identity);
        }
    }
}
