using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "DoubleVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Double")]
	public sealed class DoubleVariable : BaseVariable<double>
	{
	}
}