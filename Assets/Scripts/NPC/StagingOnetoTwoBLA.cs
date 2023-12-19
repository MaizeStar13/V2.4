using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagingOnetoTwoBLA : MonoBehaviour
{

    [Header("Object that want to be use")]
    [SerializeField] private GameObject one;
    [SerializeField] private GameObject two;


    [Header("Sound Effect")]
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;

    //conditions
    private bool staging = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && staging == false)
        {
            source.PlayOneShot(clip);
            staging = true;
            one.SetActive(false);
            two.SetActive(true);
        }
    }
}
