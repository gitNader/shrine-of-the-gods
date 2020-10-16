﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Animal", menuName = "Shrine Of The Gods/Generation/Animal")]
public class S_Animal : S_GenerationElement
{

    public Sprite sprite;
    public bool interactable;

    public override GameObject SpawnInWorld()
    {
        var animalObj = Instantiate(prefab, Vector3.zero, Quaternion.identity);

        var anim = animalObj.GetComponent<Animal>();
        anim.InitAnimal(this);

        return animalObj;
    }
}
