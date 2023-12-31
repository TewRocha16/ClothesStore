using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinpileInteraction : InteractionBase
{
    [SerializeField] private GameObject coinAnimation;
    [SerializeField] private AudioClip coinAudioClip;
    public override void Interact()
    {
        StartCoroutine("GetACoin");
    }
    public IEnumerator GetACoin()
    {
        SoundManager.PlaySound(coinAudioClip);
        coinAnimation.SetActive(true);
        PlayerManager.Instance.SetCurrency(1);
        yield return new WaitForSeconds(0.5f);
        coinAnimation.SetActive(false);
    }
}
