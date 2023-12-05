using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using UnityEngine.EventSystems;
public class ButtonBehaviour : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private string buttonName;
    [SerializeField] private UnityEvent clickEvent;
    [SerializeField] private AudioClip hoverSound;
    [SerializeField] private AudioClip pressedSound;
    private AudioSource audioSource;
    private bool canPress = true;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        GetComponent<Button>().onClick.AddListener(TaskOnClick);
        SetButtonName(buttonName);
    }
    public void SetButtonName(string _buttonName)
    {
        GetComponentInChildren<TMP_Text>().text = _buttonName;
    }
    public void TaskOnClick()
    {
        if (canPress)
            clickEvent.Invoke();
        PlayAudio(pressedSound);
        canPress = false;
        Invoke("CanPressAgain", 1);
    }
    private void CanPressAgain()
    {
        canPress = true;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        PlayAudio(hoverSound);
        Debug.Log("Mouse is over GameObject.");
    }
    void PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}