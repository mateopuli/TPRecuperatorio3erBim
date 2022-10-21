using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Muere : MonoBehaviour
{
    public GameObject perdio;
    public float textTime;
    float currTextTime;

    void Start()
    {
        perdio.SetActive(!perdio.activeInHierarchy);
        currTextTime = textTime;
    }

    void Update()
    {
        if (perdio.activeInHierarchy)
        {
            currTextTime -= Time.deltaTime;
            if (currTextTime <= 0)
            {
                perdio.SetActive(false);
                currTextTime = textTime;
            }

        }
    }
    public void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "Sillas")
        {
            perdio.SetActive(true);
            Debug.Log("Colisiona");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            perdio.SetActive(true);
        }
    }
}
