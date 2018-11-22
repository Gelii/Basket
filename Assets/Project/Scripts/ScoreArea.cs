using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {

    public GameObject effectObject;
   

    void Start()//Cada vez que se inicie la escena las particulas estaran en falso
    {
        effectObject.SetActive(false);
        
    }
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent <Ball>() != null) //si el collider trigger que hemos colocado es tocado  pasara lo siguiente
        {
            Debug.Log("¡Bien hecho!"); //la consola mostrará esta frase
            effectObject.SetActive(true);//las particulas del aro se activaran
            
        }
           
   
    }
}
