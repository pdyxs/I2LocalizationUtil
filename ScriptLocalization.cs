using UnityEngine;

namespace I2.Loc
{
	public static class ScriptLocalization
	{
		public static string Get(string Term, bool FixForRTL=true, int maxLineLengthForRTL=0, bool ignoreRTLnumbers=true, bool applyParameters=false, GameObject localParametersRoot=null, string overrideLanguage=null) { return LocalizationManager.GetTranslation(Term, FixForRTL, maxLineLengthForRTL, ignoreRTLnumbers, applyParameters, localParametersRoot, overrideLanguage); }


	}
}
