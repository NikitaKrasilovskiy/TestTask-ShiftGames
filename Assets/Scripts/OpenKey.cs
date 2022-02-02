using UnityEngine;
using System.Collections;

public class OpenKey : MonoBehaviour
{
    public GameObject stopKey;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        { stopKey.SetActive(false); }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Key"))
        { stopKey.SetActive(true); }
    }
}