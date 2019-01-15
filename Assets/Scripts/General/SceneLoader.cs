using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{

    public void LoadActionsScene()
    {
        SceneManager.LoadScene("Actions");
        Player.instance.GetComponent<BoxCollider2D>().enabled = false;
        Player.instance.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void LoadInventoryScene()
    {
        SceneManager.LoadScene("Inventory");
        Player.instance.GetComponent<BoxCollider2D>().enabled = false;
        Player.instance.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void LoadMapScene()
    {
        SceneManager.LoadScene("Map");
        Player.instance.GetComponent<BoxCollider2D>().enabled = true;
        Player.instance.GetComponent<SpriteRenderer>().enabled = true;
    }
}
