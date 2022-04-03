using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 9f;
    // Start is called before the first frame update
    void Start()
    {
        Print();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void Print()
    {
        Debug.Log("Welcome to my game!\n Dont hit thw walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
