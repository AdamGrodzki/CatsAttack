using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] AudioSource audioSound;
    float moveX;
    float moveY;
    float speed = 7f;

    void Update()
    {
        Vector3 pos = transform.position;
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        pos += new Vector3(moveX, moveY, 0)*speed*Time.deltaTime; 
        pos.x = Mathf.Clamp(pos.x, -7.5f, 7.5f);
        pos.y = Mathf.Clamp(pos.y, -3.7f, 3.7f);
        transform.position = pos;
        playSoundMovement();
    }
    void playSoundMovement()
    {
        if (Input.GetButton("Horizontal") || Input.GetButtonDown("Vertical") && !audioSound.isPlaying)
            audioSound.Play();
        else if (!Input.GetButton("Horizontal") || !Input.GetButtonDown("Vertical") && audioSound.isPlaying)
            audioSound.Stop();
    }
}
