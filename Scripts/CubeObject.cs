using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{

  public GameObject player;
  public GameObject sphere;
  //public float speed;
  //public float rotationSpeed;
  public float mintDistance = 20f;

  // Start is called before the first frame update
  void Start()
  {
    player = GameObject.FindGameObjectWithTag("Player");
    sphere = GameObject.FindGameObjectWithTag("Sphere");
  }

  // Update is called once per frame
  void Update()
  {
    
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      transform.localScale = transform.localScale * 0.8f;
    }

    if (other.gameObject.CompareTag("Sphere"))
    {
      transform.localScale = transform.localScale * 1.2f;
    }
  }
}
