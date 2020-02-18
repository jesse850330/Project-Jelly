using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int brickCount;

    public static void ReloadThisScene() {
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(current.name);
    }

    public static bool LevelClear {
        get {

            if (brickCount<=0)
            {
                return true;
            }
            return false;
        }
    }


    void Start()
    {

        brickCount = GameObject.FindGameObjectsWithTag(tags.block.ToString()).Length;
        Debug.Log("Have "+brickCount+" Breakable Blocks");
    }

    void Update()
    {

    }
}

enum tags
{
    block, background, player, ball
}