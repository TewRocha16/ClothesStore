using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
[CreateAssetMenu(fileName = "Cloth", menuName = "ScriptableObjects/Cloth")]
public class Cloth : ScriptableObject
{
    public string clothName;
    public AnimatorController ClothAnimator;
}
