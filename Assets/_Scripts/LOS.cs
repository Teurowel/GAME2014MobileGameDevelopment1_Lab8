using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LOS : MonoBehaviour
{
    public Collider2D collidesWith;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collidesWith = collision;
    }
}
