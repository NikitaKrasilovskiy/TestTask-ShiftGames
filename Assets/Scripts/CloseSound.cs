using UnityEngine;
using UnityEngine.EventSystems;

public class CloseSound : MonoBehaviour, IPointerClickHandler
{
    public Transform player;
    public AudioSource doorClose;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Vector3.Distance(transform.position, player.position) < 2)
        { doorClose.Play(); }
    }
}
