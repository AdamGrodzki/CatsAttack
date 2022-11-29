using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("i have started");
    }

    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 currentPosition = transform.position;

        Vector3 newPosition = new Vector3(currentPosition.x + inputX, currentPosition.y + inputY, 0);

        transform.position = newPosition;
    }
}
