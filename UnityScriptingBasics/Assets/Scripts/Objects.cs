using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour {

    // El tipo de una variable u objeto, tambien se conoce como Class o Clase
    public Collider collider;

    void Start() {

        // Podemos obtener o asignar valores a las propiedades de los objetos
        // Para esto se utiliza el .

        // Aca estamos accediendo o leyendo el contenido de la variable bounds
        print(collider.bounds);

        // Aca estamos asignando un valor a la variable enabled
        collider.enabled = false;


        // Tambien podemos invocar o ejecutar las funciones que 
        // tiene la clase Collider. Tambien se usa el .
        int id = collider.GetInstanceID();
        string name = collider.ToString();

        // Ejemplos:

        // Tipo o Clase int (Integer = Numero Entero)
        int salario = 500;
        salario.ToString();

        // Tipo o Clase String (= Cadena de Texto)
        string nombre = "Rigoberto";
        print(nombre.Length);

        // Tipo o Clase Vector3
        Vector3 ubicacion = new Vector3(0.5f, 0.8f, 14.63f);
        float coordX = ubicacion.x;
        print(coordX);
    }
}