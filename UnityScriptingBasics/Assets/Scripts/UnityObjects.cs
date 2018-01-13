using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;

public class UnityObjects : MonoBehaviour {

    // Operador this
    void ThisOperations() {

        // this se refiere a éste script
        string nombre = this.name;
        bool activo = this.enabled;

        // Éste script sabe quien es su contenedor (GameObject)
        GameObject contenedor = this.gameObject;
    }


    // GameObject
    public GameObject cubo;

    void DemoGameObject() {

        cubo.tag = "Background";
        cubo.SetActive(true);

        print(cubo.activeSelf);
        print(cubo.activeInHierarchy);

        print(cubo.layer);
        print(cubo.isStatic);


        // Manipulacion de Componentes

        // Obtener Componentes
        Light luz = cubo.GetComponent<Light>();
        Camera camara = cubo.GetComponent<Camera>();
        Rigidbody body = cubo.GetComponent<Rigidbody>();
        Animator animator = cubo.GetComponent<Animator>();


        // Este es un shortcut que solo aplica al componente transform
        // Ya que todo game object tiene un Transform
        Transform transA = cubo.GetComponent<Transform>();
        Transform transB = cubo.transform;


        // Son similares, pero hacen cosas diferentes
        BoxCollider boxA = this.GetComponent<BoxCollider>();
        BoxCollider boxB = cubo.GetComponent<BoxCollider>();



        // Agregar componentes
        Camera nuevaCamara = cubo.AddComponent<Camera>();
        nuevaCamara.backgroundColor = Color.green;
        nuevaCamara.orthographicSize = 0.7f;
    }


    // Componente Transform
    public Transform piramidTransform;

    void DemoTransform() {

        // Un transform puede conocer cual transform es su padre
        Transform padreTransform = piramidTransform.parent;

        // Un transform sabe quien es su contenedor (GameObject)
        GameObject padreGameobject = padreTransform.gameObject;


        // Funciones mas conocidas
        piramidTransform.Rotate(Vector3.up);
        piramidTransform.Translate(Vector3.forward);
        piramidTransform.LookAt(new Vector3(4, 7, 2));
        piramidTransform.localScale = Vector3.one * 5;


        // Datos mas conocidos
        int cantidadDeHijos = piramidTransform.childCount;
        Vector3 pos = piramidTransform.localPosition;
        Vector3 scale = piramidTransform.localScale;


        // Buscar un transform hijo con un nombre especifico
        piramidTransform.Find("Star");
    }



    // Componente Collider
    public Collider collider;
    public PhysicMaterial caucho;

    void DemoCollider() {

        collider.enabled = true;
        collider.isTrigger = false;
        collider.material = caucho;

        print(collider.bounds);
        print(collider.attachedRigidbody);
    }
}