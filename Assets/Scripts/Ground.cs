using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] MeshFilter groundMesh;

    public Vector3 GetRandomGroundPos()
    {
        return GetRandomGroundPos(groundMesh);
    }

    Vector3 GetRandomGroundPos(MeshFilter filter)
    {
        if (filter == null) { return Vector3.zero; }

        Bounds bound = filter.mesh.bounds;
        float xPos = Random.Range(bound.min.x, bound.max.x);
        float yPos = Random.Range(bound.min.y, bound.max.y);

        return new Vector3(xPos, 0, yPos);
    }
}
