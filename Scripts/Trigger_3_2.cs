using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_3_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnTriggerStay(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      if (Input.GetKeyDown("space"))
      {
        other.gameObject.transform.LookAt(transform.eulerAngles + 180f * Vector3.up);
        other.gameObject.transform.Translate(other.gameObject.transform.forward * 100 * Time.deltaTime);
      }
    }
  }
}
