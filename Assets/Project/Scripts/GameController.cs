using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Añadimos esto para poder acceder a otros clases, metodos y variables de unity. En este caso relacionados con el control de la escena, como pausarla, reiniciarla...

public class GameController : MonoBehaviour {

	public Player player; //Aqui estoy heredando la clase Player a otra nueva clase llamada player, hay que meterlo en el gamecontroller desde el editor para que tengamos la informacion que contiene el script Player
    public float resetTimer = 5f; //Creamos un temporizador y le damos 5 segundos
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.holdingBall == false) { //Si el jugador no está sujetando la pelota el temporizador se pondra en marcha hacia cero
			resetTimer -= Time.deltaTime;
            if (resetTimer <= 0) { //si el temporizador llega a cero se reiniciará la escena por completo
                SceneManager.LoadScene("Basket");
            }
		}
	}
}
