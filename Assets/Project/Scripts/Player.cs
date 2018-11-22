using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Ball ball;
	public GameObject playerCamera;
	public GameObject pared;

	public float ballDistance = 2f;
	public float ballThrowingForce = 5f;

	public bool holdingBall = true; //crearemos esto para luego mas tarde poder comprobar si el jugador tiene la pelota o no 

	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody> ().useGravity = false; //le quitamos la gravedad nada mas empezar la escena porque la pelota la tendra el jugador y no queremos que caiga al suelo
	}
	
	// Update is called once per frame
	void Update () {
		if (holdingBall) {//si el jugador esta sujetando la pelota, si holding ball es true, esto se activara.
			ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;//La posición de la pelota será la misma que la de la cámara + hacia donde mira la cámara * una distancia que pusimos pública para que el editor de niveles pueda configurarlo desde unity

			if (Input.GetMouseButtonDown (0)) { //si lo anterior se cumple y si pulsamos el click izq = 0, se cumplirá lo siguiente
				holdingBall = false;//El jugador ha lanzado la pelota asique esto debe de pasar a ser falso, por ello lo cambiamos aqui, porque sabemos que el jugador ha pulsado el boton de lazar
                ball.ActivateTrail();//Activamos la cola de particulas de la pelota que hemos creado
				ball.GetComponent<Rigidbody> ().useGravity = true;//La pelota volverá a tener gravedad, pues ya no la tendrá el jugador y tiene que poder caer al suelo
                ball.GetComponent<Rigidbody> ().AddForce (playerCamera.transform.forward * ballThrowingForce);//Le añadimos fuerza al lanzamiento, que sera en la direción que mira la cámara y con una fuerza que pusimos pública para que el editor de niveles pueda configurarlo desde unity
            } 
		} else if (Input.GetMouseButtonDown (0)) {//si pulsamos click izq cuando holding ball es false volveremos a poner true el holding ball, desactivaremos la gravedad y las particulas de la pelota. 
			holdingBall = true;
			ball.GetComponent<Rigidbody> ().useGravity = false;
            ball.DesactivateTrail();
        }


	}
}
