using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int souls = 0;

    [SerializeField] private Text soulsText;
    [SerializeField] private AudioSource soulSound;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Soul")){
            soulSound.Play();
            Destroy(collision.gameObject);
            souls++;
            soulsText.text = "Souls: " + souls;
        }
    }
}
