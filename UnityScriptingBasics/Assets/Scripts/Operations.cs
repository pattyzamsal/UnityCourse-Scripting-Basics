using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour {

    void Start() {

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/

        int edadPedro;

        // Las instrucciones se ejecutan de manera secuencia
        // Hasta que no acabe una instruccion, no se ejecuta la siguiente
        // A no ser que se especifique lo contrario (Thread)
        edadPedro = 50 + 80;
        edadPedro = 90 + 120;
        edadPedro = edadPedro + 5;


        // Algunas operaciones tienen shotcuts
        edadPedro++; // edadPedro = edadPedro + 1;
        edadPedro--; // edadPedro = edadPedro - 1;


        // Podemos realizar operaciones entre variables
        int edadDiana = 10;


        // Operaciones aritmeticas (int y float)
        int edadAmbos = edadPedro + edadDiana;
        int multiplica = edadPedro * edadDiana;
        int diferenciaDeEdad = edadPedro - edadDiana;
        int division = edadDiana / edadPedro;


        // Concatenacion (string)
        string parteA = "Te Amo ";
        string parteB = "Catalina";

        string mensaje = parteA + parteB;
        print(mensaje);


        // Operaciones logicas OR AND (bool)
        bool haceEjercicio = true;
        bool comeSano = true;
        bool tieneBuenaSalud = haceEjercicio && comeSano;

        bool tienePlata = true;
        bool tieneNovia = true;
        bool esFeliz = tienePlata || tieneNovia;


        // Operaciones de comparacion
        int edadJuan = 20;
        int edadMaria = 25;

        bool juanEsMayor = edadJuan > edadMaria;
        bool tieneIgualEdad = edadJuan == edadMaria;
        bool mariaEsMenorOIgual = edadMaria <= edadJuan;


        // Podemos comparar propiedades de un objeto
        string poema = "Una noche una noche toda llena de perfumes, de murmullos y de música de alas";

        // El poema es aburrido si tiene mas de 20 letras
        bool poemaEsAburrido = poema.Length > 20;


        // El personaje pasó la linea de meta si 
        // su posicion en el eje X es mayor o igual a 100
        Vector3 posicionPersonaje = new Vector3(120, 0, 0);

        bool pasoLineaDeMeta1 = posicionPersonaje.x >= 100;

        // Las operaciones se pueden hacer en una funcion aparte
        bool pasoLineaDeMeta2 = verificarSiPasoLineaDeMeta(posicionPersonaje);
    }

    bool verificarSiPasoLineaDeMeta(Vector3 position) {
        return position.x >= 100;
    }
}
