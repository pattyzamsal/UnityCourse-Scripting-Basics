using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAround : MonoBehaviour {

    // Este transform seria el del Sol
    public Transform translationPivot;

    // Esta es la velocidad de rotacion alrededor del Sol
    public float translationSpeed;

    void Update() {

        // Delta time es usado para evitar que la velocidad 
        // de rotacion sea diferente cuando se ejecute en 
        // procesadores mas rapidos o lentos
        float rotationMagnitude = translationSpeed * Time.deltaTime;

        // Le solicitamos al componente Transform que ejecute la translacion
        this.transform.RotateAround(translationPivot.position, Vector3.up, rotationMagnitude);
    }
}
