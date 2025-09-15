using System;
using Unity.VisualScripting;
using UnityEngine;

public class bau : MonoBehaviour
{
    public GameObject texto;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            texto.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}  
    