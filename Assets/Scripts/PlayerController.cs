using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
  private Rigidbody player;

  public int points;
  public float playerVelocity;

  public TMPro.TextMeshProUGUI textoContador, textoGanar;

  // Start is called before the first frame update
  void Start()
  {
    player = GetComponent<Rigidbody>();
    points = 0;
    setTextoContador();
    textoGanar.text = "";
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

  //Se ejecuta al entrar a un objeto con la opción isTrigger seleccionada
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Coleccionable"))
    {
      other.gameObject.SetActive(false);
      points++;
      setTextoContador();
    }
  }

  void setTextoContador()
  {
    textoContador.text = "Contador:" + points.ToString();
    if (points >= 15)
    {
      textoGanar.text = "Ganaste!";
    }
  }
}
