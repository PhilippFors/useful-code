using UnityEngine;

namespace UsefulCode.SOArchitecture
{
	[System.Serializable]
	public class Vector3Reference : BaseReference<Vector3, Vector3Variable>
	{
	    public Vector3Reference() : base() { }
	    public Vector3Reference(Vector3 value) : base(value) { }
	}
}