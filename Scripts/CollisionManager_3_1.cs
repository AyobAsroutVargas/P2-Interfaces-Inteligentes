using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager_3_1 : MonoBehaviour
{
  public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      player.GetComponent<Score>().AddScore();
      transform.localScale = transform.localScale * 1.2f;
    }
  }
}
