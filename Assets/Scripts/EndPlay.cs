using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlay : MonoBehaviour
{
    [SerializeField] GameManager GM;

    private void OnTriggerEnter(Collider Col)
    {

        if (Col.tag == "Player")
        {
            GM.End();


        }
    }
}
