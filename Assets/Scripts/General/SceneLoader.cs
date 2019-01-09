using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{

    public void LoadActionsScene()
    {
        SceneManager.LoadScene("Actions");
    }

    public void LoadInventoryScene()
    {
        SceneManager.LoadScene("Inventory");
    }
}
