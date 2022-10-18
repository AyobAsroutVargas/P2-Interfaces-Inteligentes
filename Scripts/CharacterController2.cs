using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2 : MonoBehaviour
{
  public float speed;
  public float rotationSpeed;


  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float horizontal = Input.GetAxis("Horizontal2");
    float vertical = Input.GetAxis("Vertical2");
    float mouseY = Input.GetAxis("YRotation2");

    Vector3 movement = transform.right * horizontal + transform.forward * vertical;
    movement = movement * speed * Time.deltaTime;

    Vector3 rotation = transform.up * mouseY * rotationSpeed * Time.deltaTime;

    transform.Translate(movement);
    transform.Rotate(rotation);
  }
}
