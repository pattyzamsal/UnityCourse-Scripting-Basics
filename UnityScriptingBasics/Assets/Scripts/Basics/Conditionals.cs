using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {

    void Start() {

        // Conditionales u Operadores de Seleccion
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/selection-statements


        // Instruccion 1

        // Condicional IF
        bool entrada = false;

        // El procesador ejecuta las instrucciones dentro
        // del cuerpo del IF, si la instruccion dentro del 
        // parentesis es true
        if(entrada == true) {
            print("Pude entrar");
        }
        // Instruccion 5



        // Dejamos entrar a lorena al bar si es mayor de 18 años
        int edadLorena = 15;
        bool lorenaEsFeliz = false;

        if(edadLorena >= 18) {

            // Lorena si puede entrar
            lorenaEsFeliz = true;
        }
        // Aca pueden ir mas instrucciones...
        print(lorenaEsFeliz);



        // Condicional IF ELSE
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
        bool tengoTicketVIP = true;

        if(tengoTicketVIP == true) {
            print("El concierto es genial!");

        } else {
            print("Soy pobre... Nooo!!!");
        }
        // Instruccion 6



        // Condicional SWITCH
        // https://msdn.microsoft.com/en-us/library/06tc147t(v=vs.120).aspx
        int distancia = 50;

        switch(distancia) {
            case 80:
                print("El valor de la distancia es 80");
                break;

            case 70:
                print("El valor de la distancia es 70");
                break;

            case 22:
                print("El valor de la distancia es 22");
                break;

            default:
                print("El valor de diferente a 80, 70 y 22");
                break;
        }
    }
}