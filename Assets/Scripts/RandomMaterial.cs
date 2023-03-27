using UnityEngine;

public class RandomMaterial : MonoBehaviour
{
	public Material[] BlockSurfaces; // array of Mats

	void Start ()
	{
		var rend = GetComponent<MeshRenderer> ();
		rend.material = BlockSurfaces[Random.Range (0, BlockSurfaces.Length)];
	}
}