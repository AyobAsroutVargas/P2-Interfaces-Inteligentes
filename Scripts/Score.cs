using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

  public int score;
    // Start is called before the first frame update
    void Start()
    {
      score = 0;
      Debug.Log("Score = " + score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
      score += 1;
      Debug.Log("Score = " + score.ToString());
    }

  //private void OnCollisionEnter(Collision collision)
  //{
  //  if (collision.gameObject.CompareTag("3-1 Cylinder"))
  //  {
  //    score += 1;
  //    transform.localScale = transform.localScale * 1.2f;
  //    Debug.Log("Score = " + score.ToString());
  //  }
  //}
}
