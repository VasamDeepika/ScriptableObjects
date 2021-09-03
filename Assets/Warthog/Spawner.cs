using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class Spawner : IComponentData
{
    public Entity prefab;
    public int eRows, eCols;
}
