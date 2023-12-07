using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesManager : MonoBehaviour
{
    [SerializeField] private List<Cloth> clothes;
    [SerializeField] private Animator clothAnimator;
    public Animator ClothAnimator { get => clothAnimator; set => clothAnimator = value; }
    public void SetupNewCloth(string clothName)
    {
        foreach (var cloth in clothes)
        {
            if (cloth.clothName == clothName)
            {
                clothAnimator.runtimeAnimatorController = cloth.ClothAnimator;
            }
        }
    }
}
