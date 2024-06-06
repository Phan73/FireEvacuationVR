using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TriangleCreator : MonoBehaviour
{
    void Start()
    {
        // Create a new Mesh
        Mesh mesh = new Mesh();

        // Define the vertices of the triangle
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(0, 0, 0), // Bottom left
            new Vector3(1, 0, 0), // Bottom right
            new Vector3(0.5f, 1, 0) // Top
        };

        // Define the order of the vertices to form a triangle
        int[] triangles = new int[]
        {
            0, 1, 2
        };

        // Assign the vertices and triangles to the mesh
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // Recalculate normals and bounds
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        // Get the MeshFilter component and assign the mesh to it
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;
    }
}
