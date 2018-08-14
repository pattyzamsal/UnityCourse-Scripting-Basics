using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

    // Esto es una funcion, invocada por Unity
    void Start() {
        // Instruction 1
        // Instruction 2
        // Instruction 3
    }

    // Tambien es invocada por Unity
    // El signature o firma de esta funcion es void Update()
    void Update() {
        // Instruction X
        // Instruction Y
        // Instruction Z
    }




    // Esta es una funcion creada por mi, por lo tanto,
    // No es invocada o ejecutada por Unity, necesita ser 
    // invocada manualmente desde
    void MyFunction() {
        // Instruction A
        // Instruction B
        // Instruction C
    }

    // Awake es invocada por Unity
    void Awake() {

        // Instruction 1

        // Aqui estamos llamando la funcion void MyFunction()
        MyFunction();

        // Instruction 3
    }








    // Las funciones pueden recibir una o mas Variables de Entrada
    void CrearUsuario(int edad, string saludo) {
        // Instruccion 1
        // Instruccion 2
        // Instruccion 3
    }

    // Las funciones pueden Retornar una un valor
    int CalculoDeEdad() {
        // Instruccion X
        // Instruccion Y
        // Instruccion X

        // Aqui se retorna el numero 6 a
        // quien haya invocado esta funcion
        int edad = 6;
        return edad;
    }

    // Las funciones pueden recibir variables, ejecutar sus 
    // operaciones y finalmente retornar un valor de tipo float
    float CalculoDeDistancia(Vector2 puntoA, Vector2 puntoB) {
        // Instruccion A
        // Instruccion B
        // Instruccion C
        return 78.6f;
    }

    // Ejemplos:
    int Suma(int numeroA, int numeroB) {
        return numeroA + numeroB;
    }

    int Resta(int numeroA, int numeroB) {
        return numeroA - numeroB;
    }









    // Como invoco o ejecuto estas funciones?
    void OnEnable() {

        // Funcion que recibe variables de entrada
        CrearUsuario(45, "Hola");

        // Funcion que retorna un valor
        int edadPedro = CalculoDeEdad();
        print(edadPedro);

        // Funcion que recibe variables de entrada y retorna una valor
        int total = Suma(30, 20);
        print(total);

        // Otro ejemplo
        Vector2 posicionPersonaje = new Vector2(25, -70);
        Vector2 posicionEnemigo = new Vector2(56, 32);

        float distanciaEntreEllos = CalculoDeDistancia(posicionPersonaje, posicionEnemigo);
        print(distanciaEntreEllos);
    }




    void ScopeDeVariables() {

        // Estas variables declaradas dentro 
        // de una funcion no tienen la palabra public
        string saludo = "Hola :)";
        bool puertaAbierta = false;

        // Tan pronto como la funcion acabe su ejecucion,
        // la variable es eliminada de la memoria RAM
    }
}