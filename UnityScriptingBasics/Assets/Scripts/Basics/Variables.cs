using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    /* 
     * Variables, Propiedades, Objectos, Instancias
     * El nombre varia dependiendo de donde se utilice
     * Pero basicamente representan lo mismo:
     * Espacios de memoria RAM
    */

    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types


    // Esto se conoce como Declarar una Variable

    // Variables Primitivas (o Value Types)
    public bool esHombre;
    public int edad;
    public float altura;
    public string presentacion;


    // Variables Compuestas (Objetos)
    public GameObject usuario;
    public Color colorCabello;
    public Vector2 cuadrado;
    public Vector3 ubicacion;
    public ParticleSystem lluvia;
    public Light luzDelSol;
    public Collider box;


    // Si la variable no tiene la palabra public
    // no será visible en el Unity Editor

    // Esto se llama Declarar e Inicializar una variable
    bool estaSoltera = false;
    int profundidad = -80;
    float distancia = 23.67f;
    string nombre = "Katherine";

    // Estos valores, usados en la inicializacion se llaman Literal Values


    void Start() {

        // Esto se llama Asignar un Literal o Valor a una variable
        altura = 1.75f;
        presentacion = "Mi nombre es Carlos";
        esHombre = false;

        // Para la asignacion se usa el operador =


        // La asignacion se puede hacer tantas veces como se quiera
        esHombre = true;
        esHombre = false;


        // Vamos a cambiar el valor de la variable edad a 50
        edad = 50;

        // Ahora, despues de ejecutar esta instruccion, edad vale 70
        edad = 70;


        // Ejemplos de asignaciones erroneas
        //edad = "Hola";
        //altura = true;
        //presentacion = 67.3f;
        //esHombre = "Pedro";


        // Para asignar valores a una variable compuesta (Objeto)
        // Se usan Constructores, los cuales inicializan las variables internas
        Color otroColor = new Color(0.5f, 0.3f, 0.1f);
        Vector3 posicion = new Vector3(1, 2, 4);
        GameObject casa = new GameObject("hogar");


        // Algunos Constructores tiene versiones mas cortas
        Color colorDelCielo1 = new Color(0.0f, 0.0f, 1.0f);
        Color colorDelCielo2 = Color.blue;

        Vector3 posicionBoss1 = new Vector3(1, 0, 0);
        Vector3 posicionBoss2 = Vector3.right;


        // Para utilizar una variable, esta debe ser declarada primero
        //longitud = 34;
        //int longitud;


        // Siempre es recomendable darle un valor inicial
        // a todas las variables, sino podemos obtener null

        // Que valor contiene la variable presion?
        float presion;
    }
}