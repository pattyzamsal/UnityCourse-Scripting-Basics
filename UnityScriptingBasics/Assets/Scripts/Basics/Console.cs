using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour {

	void Start () {

        // Impresion de Info en consola
        Debug.Log("Este texto será mostrado en la consola, es muy util!");
        print("Este texto también será impreso...");

        // Impresion de un Warning en consola
        Debug.LogWarning("Ha sucedido un una situacion no esperada");

        // Impresion de un Error en consola
        Debug.LogError("Ha sucedido un error");

        // Impresion del contenido de una variable
        int edad = 25;
        print("Mi edad es " + edad);

        Vector3 ubicacion = Vector3.right;
        print("Mi ubicación es " + ubicacion);
	}
}