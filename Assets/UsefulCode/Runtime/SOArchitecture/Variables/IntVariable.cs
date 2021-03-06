using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "IntVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Int")]
	public sealed class IntVariable : BaseVariable<int>
	{
	}
}