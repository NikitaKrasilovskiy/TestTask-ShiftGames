using UnityEngine;
using UnityEngine.EventSystems;

public class OpenDoor : MonoBehaviour, IPointerClickHandler
{
    public Transform player;
    private Animator animator;
    public bool opendoor;
    public Collider stopKey;
    public AudioSource closeDoor, openDoor;
    private void Start()
    { animator = GetComponent<Animator>(); }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Vector3.Distance(transform.position, player.position) < 2 && opendoor == false)
        {
            animator.SetTrigger("Open");
            opendoor = true;
            stopKey.enabled = false;
            openDoor.Play();
        }
        else if (Vector3.Distance(transform.position, player.position) < 3 && opendoor)
        {
            animator.SetTrigger("Close");
            opendoor = false;
            stopKey.enabled = true;
            closeDoor.Play();
        }
    }
}
