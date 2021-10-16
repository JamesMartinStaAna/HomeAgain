using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract_SpriteSwap : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite ActiveSprite;
    public Sprite InactiveSprite;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        spriteRenderer.sprite = ActiveSprite;
    }

    private void OnTriggerExit(Collider collision)
    {
        spriteRenderer.sprite = InactiveSprite;
    }
}
