using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDeSillas : MonoBehaviour
{
    [SerializeField] GameObject[] objectsCollection;
    // Start is called before the first frame update
    void Start()
    {
        objectsCollection = GameObject.FindGameObjectsWithTag("Silla");
        AgregarColliderAElementosDelArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            PosicionarElementosDelArray();
        }
    }

    void PosicionarElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].transform.position = new Vector3(-11.39899f + i, 1f, 6.471744f);
        }
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].AddComponent<BoxCollider>();
        }
    }
}
