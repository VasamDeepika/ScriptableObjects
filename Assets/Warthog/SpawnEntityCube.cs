using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SpawnEntityCube : MonoBehaviour, IDeclareReferencedPrefabs, IConvertGameObjectToEntity
{
    public GameObject entityCube;
    public int rows, cols;
    public void DeclaredReferencePrefabs(List<GameObject> gameObjects)
    {
        gameObjects.Add(entityCube);
    }
    public void Convert(Entity entity, EntityManager entityManager, GameObjectConversionSystem conversionSystem)
    {
        var spawnerData = new Spawner
        {
            prefab = conversionSystem.GetPrimaryEntity(entityCube),
            eRows = rows,
            eCols = cols,
        };
        entityManager.AddComponentData(entity,spawnerData);
    }
}
