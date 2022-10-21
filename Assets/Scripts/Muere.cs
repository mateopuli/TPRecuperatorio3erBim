using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Muere : MonoBehaviour
{
    public void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "Sillas")
        {
            Debug.Log("Colisiona");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
