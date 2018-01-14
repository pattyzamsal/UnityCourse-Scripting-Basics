using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour {

    // Rotation speed of each planet is different
    public float rotationSpeed;

    void Update() {

        // Delta time es usado para evitar que la velocidad 
        // de rotacion sea diferente cuando se ejecute en 
        // procesadores mas rapidos o lentos
        float rotationMagnitude = rotationSpeed * Time.deltaTime;

        // La rotacion es un vector, en este caso, que apunta
        // hacia arriba, su magnitud es la velocidad de rotation
        Vector3 rotationVector = Vector3.up * rotationMagnitude;

        // Le solicitamos al componente Transform que ejecute la rotacion
        this.transform.Rotate(rotationVector);
    }
}

// Las texturas se pueden obtener aca:
// https://www.solarsystemscope.com/textures

// Velocidades orbitales
// http://planetfacts.org/orbital-speed-of-planets-in-order/

// Tamaño:
// https://www.universetoday.com/36649/planets-in-order-of-size/