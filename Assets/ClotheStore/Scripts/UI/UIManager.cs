using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Store Store;
    public TMP_Text CoinUI;
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        CloseUI();
    }
    void CloseUI()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Store.gameObject.SetActive(false);
        }
    }
}
