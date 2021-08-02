using UnityEngine;

namespace Data
{
	[System.Serializable]
	public class LayerMaskReference : BaseReference<LayerMask, LayerMaskVariable>
	{
	    public LayerMaskReference() : base() { }
	    public LayerMaskReference(LayerMask value) : base(value) { }
	}
}