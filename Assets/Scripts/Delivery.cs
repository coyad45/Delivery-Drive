using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery: MonoBehaviour
{   
    //Verificacion de si tiene o no el paquete
    bool hasPackage;

    //Cambio de color
    [SerializeField] Color32 hasPackageColor= new Color32(255,0,10,255);
    [SerializeField] Color32 hasNotPackageColor= new Color32(255,255,255,255);

    //Segundos antes del gameObject sea destruido
    [SerializeField] float secondDestroy = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   
   //Se activa al colisionar con un arbol o una casa que tenga collider
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Me dolio puto");
    }

    //Se activa al activar el trigger de un package o un costumer 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Package" && !hasPackage)
        {
             Debug.Log("Package pick up");
             hasPackage=true;
             spriteRenderer.color=hasPackageColor;
             Destroy(other.gameObject,secondDestroy);
             
             
        }    
        else if (other.tag=="Customer"&& hasPackage)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
            spriteRenderer.color=hasNotPackageColor;
        }
       
    }
}