using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject GameWinScreen;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            Debug.Log("You won");
            GameWinScreen.SetActive(true);
        }
    }
}
