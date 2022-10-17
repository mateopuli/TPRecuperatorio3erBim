using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioNivel : MonoBehaviour
{
    public bool ShowCursor = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            SceneManager.LoadScene("Ganaste");
            if (ShowCursor == false)
            {
                Cursor.visible = true;
            }
        }

    }
}
