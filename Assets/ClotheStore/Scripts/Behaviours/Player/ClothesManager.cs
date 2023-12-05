using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesManager : MonoBehaviour
{
    [SerializeField] private List<Cloth> clothes;
    [SerializeField] private Animator clothAnimator;
    private Cloth actualCloth;
    public Animator ClothAnimator { get => clothAnimator; set => clothAnimator = value; }
    public Cloth ActualCloth { get => actualCloth; set => actualCloth = value; }

    public void SetupNewCloth(string clothName)
    {
        foreach (var cloth in clothes)
        {
            if (cloth.clothName == clothName)
            {
                ActualCloth = cloth;
                clothAnimator.runtimeAnimatorController = cloth.ClothAnimator;
            }
        }
    }
}
