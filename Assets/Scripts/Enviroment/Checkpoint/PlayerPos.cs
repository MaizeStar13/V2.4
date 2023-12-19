using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

     GameMaster gm;

    // Start is called before the first frame update
    void Start()
    {
        Tospawntpoint();
    }

    public void Tospawntpoint() {

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        gm.getLastCheckPoint();
        transform.position = gm.LastCheckPointPos.position;
    }
}
