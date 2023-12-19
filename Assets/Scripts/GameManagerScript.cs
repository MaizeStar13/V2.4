using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerPos ps;
    public GameMaster gm;

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        /*gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        gm.getLastCheckPoint();
        transform.position = gm.LastCheckPointPos.position;*/

        /*ps.Tospawntpoint();*/
        /*SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);*/
    }
}
