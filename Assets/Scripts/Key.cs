using UnityEngine;
using UnityEngine.EventSystems;

public class Key : MonoBehaviour, IPointerClickHandler
{
    public Transform player;
    private bool keyGo = false;
    private float speed = 5f;
    public AudioSource keyTake, keyPut;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Vector3.Distance(transform.position, player.position) < 2 && keyGo == false)
        { keyGo = true; keyTake.Play(); }

        else if (Vector3.Distance(transform.position, player.position) < 2 && keyGo)
        { keyGo = false; keyPut.Play(); }
    }
    private void Update()
    {
        if (keyGo)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, player.position) <= 1)
            { speed = 0.5f;}

            else if (Vector3.Distance(transform.position, player.position) >= 2)
            { speed = 5f;}
        }
    }
}
