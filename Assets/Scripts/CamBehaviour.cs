using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehaviour : MonoBehaviour
{
    public GameObject player; /* Player reference */
    private Vector3 offset; /* camera and player difference */
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
 
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
