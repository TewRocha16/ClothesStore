using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;
[CreateAssetMenu(fileName = "Cloth", menuName = "ScriptableObjects/Cloth")]
public class Cloth : ScriptableObject
{
    public string clothName;
    public RuntimeAnimatorController ClothAnimator;
}
