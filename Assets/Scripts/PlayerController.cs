using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody player;

  public float playerVelocity;

  // Start is called before the first frame update
  void Start()
  {
    player = GetComponent<Rigidbody>();
  }

  void FixedUpdate()
  {
    // Movements vars
    float movH = Input.GetAxis("Horizontal");
    float movV = Input.GetAxis("Vertical");

    Vector3 movements = new Vector3(movH, 0.0f, movV);
    player.AddForce(movements * playerVelocity);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
