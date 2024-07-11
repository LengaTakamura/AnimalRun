using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] AudioClip _audioClip;

    [SerializeField]AudioSource _audioSource;

    public abstract void Activate();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Debug.Log("�A�C�e���擾");

            _audioSource.PlayOneShot(_audioClip);

            Activate();

        }
        
    }
    
   
}
