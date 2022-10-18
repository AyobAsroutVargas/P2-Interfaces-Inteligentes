using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAway : MonoBehaviour
{

  public GameObject player;
  public float speed;
  public float rotationSpeed;
  public float lookAtDistance = 20f;

    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
      float distance = Vector3.Distance(player.transform.position, transform.position);
      if (distance < lookAtDistance)
      {
        Quaternion targetRotation = Quaternion.LookRotation(transform.position - player.transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * speed);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
      }
    }
}
