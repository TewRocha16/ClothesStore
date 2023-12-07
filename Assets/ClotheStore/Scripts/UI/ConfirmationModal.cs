using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ConfirmationModal : MonoBehaviour
{
    [SerializeField] TMP_Text itemName;
    [SerializeField] TMP_Text description;
    [SerializeField] ButtonBehaviour button;
    public GameObject modalGameObject;
    public void Setup(string _itemName, string _description, UnityEvent action, string buttonName)
    {
        itemName.text = _itemName;
        description.text = _description;
        button.clickEvent = action;
        button.SetButtonName(buttonName);
    }
}
