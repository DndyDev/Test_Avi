using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class Button : MonoBehaviour, IPointerClickHandler {
    [SerializeField] private string anmitorParametr = "anim";
    [SerializeField] private LoadSprites loader;
    private bool on;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData) {
        on = true;
    }


    void Update() {
        if (on) {
            animator.SetBool(anmitorParametr, true);
            loader.Load();
        }
    }
}
