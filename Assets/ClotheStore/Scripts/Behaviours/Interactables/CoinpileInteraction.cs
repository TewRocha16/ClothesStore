using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinpileInteraction : InteractionBase
{
    public GameObject coinAnimation;
    public override void Interact()
    {
        StartCoroutine("GetACoin");
    }
    public IEnumerator GetACoin()
    {
        coinAnimation.SetActive(true);
        PlayerManager.Instance.SetCurrency(1);
        yield return new WaitForSeconds(0.5f);
        coinAnimation.SetActive(false);
    }
}
