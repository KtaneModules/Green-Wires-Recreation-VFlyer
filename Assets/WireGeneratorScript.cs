using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SRND = System.Random;
using Random = UnityEngine.Random;
using WireGen = WireGenerator.MeshGenerator;

public class WireGeneratorScript : MonoBehaviour {
	public MeshFilter affectedWire;
	public MeshFilter[] clonedWires;
	// Use this for initialization
	void Awake () {
		var rng = new SRND(Random.Range(int.MinValue, int.MaxValue));
		var points = WireGen.GenerateWire(rng);
		var generatedMesh = WireGen.GenerateWireMesh(points, Color.white);
		affectedWire.sharedMesh = generatedMesh;
		foreach (var filter in clonedWires)
			filter.sharedMesh = generatedMesh;
	}
}
