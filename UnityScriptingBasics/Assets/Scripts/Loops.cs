using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    void Start() {

        // Estructuras ciclicas, Loops, Operadores de Iteracion
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/iteration-statements


        // Loop WHILE
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while

        // Al inicio, no tenemos plata ahorrada
        int plataAhorrada = 0;

        // La meta es conseguir 50.000 pesos, mientras no los tengamos
        while(plataAhorrada < 50000) {

            // Agregamos 10.000 pesos al ahorro
            plataAhorrada = plataAhorrada + 10000;
        }
        // Aca puede ir mas instrucciones...



        // Error tipico: Que la condicion siempre sea true
        bool condicion = true;

        while(condicion) {
            print("Hola!");
        }



        // Loop FOR
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for

        for(int index = 1; index <= 5; index++) {
            print(index);
        }
    }
}
