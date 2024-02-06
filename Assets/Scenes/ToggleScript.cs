using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public GameObject activeGameObject;
    // Start is called before the first frame update
    public void ActivateGameObject()
    {

        if (activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);

        }
        else
        {
            activeGameObject.SetActive(false);

        }

    }
}
